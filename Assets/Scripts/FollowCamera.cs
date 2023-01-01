using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _lerpSpeed = 0.01f;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _player.transform.position + _offset, _lerpSpeed);
    }
}
