using UnityEngine;

public class EnemyHealthHandler : MonoBehaviour
{
    [SerializeField] private float _health = 30;

    public void TakeDamage()
    {
        _health -= PlayerStats.stats.GetDamage();
        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        TakeDamage();
    }
}
