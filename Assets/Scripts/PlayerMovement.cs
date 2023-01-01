using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _movementSpeed = 5;
    [SerializeField] private float _rotationSpeed = 360;

    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    private Quaternion _lookDirection;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float _directionX = _joystick.Horizontal;
        float _directionZ = _joystick.Vertical;
        PlayerAnimations.animations.SetWalkingAnim(_directionX, _directionZ);
        _moveDirection = new Vector3(_directionX, 0, _directionZ).normalized;
        _lookDirection = Quaternion.LookRotation(_moveDirection);
    }

    private void FixedUpdate()
    {
        if (_moveDirection == Vector3.zero)
        {
            return;
        }
        _rigidbody.MovePosition(transform.position + _movementSpeed * _moveDirection * Time.fixedDeltaTime);
        _rigidbody.MoveRotation(_lookDirection);
    }
}
