using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float _damage = 20;

    public void GetDamage()
    {
        PlayerStats.stats.TakeDamage(_damage);
    }

}
