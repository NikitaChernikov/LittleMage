using System.Collections;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
    [SerializeField] private Transform _attackStartPoint;
    [SerializeField] private GameObject _fireball;

    private void Start()
    {
        StartCoroutine(CastAttackAnimation());
    }

    private IEnumerator CastAttackAnimation()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            PlayerAnimations.animations.Attack(0.5f);
            yield return new WaitForSeconds(0.9f);
            PlayerAnimations.animations.Attack(0f);
        }
    }

    public void CastFireballs()
    {
        Instantiate(_fireball, _attackStartPoint.transform.position, _attackStartPoint.transform.rotation);
    }

}
