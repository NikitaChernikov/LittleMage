using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats stats;

    private float _armour = 1;
    private float _health = 100;
    private float _damage = 10;
    private int _gold = 0;

    private void Awake()
    {
        stats = this;
    }

    public void TakeDamage(float amount)
    {
        _health -= (amount / _armour);
        if (_health <= 0)
        {
            Death();
        }
    }

    public int GetGold()
    {
        return _gold;
    }

    public float GetDamage()
    {
        return _damage;
    }

    private void Death()
    {
        PlayerAnimations.animations.Die();
        GetComponent<PlayerAttacks>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
    }
}
