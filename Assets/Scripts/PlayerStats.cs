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

    public void AddHealth()
    {
        if (_health >= 91) _health = 100;
        else _health += 10;
    }

    public void AddArmour()
    {
        _armour *= 1.5f;
    }

    public void AddGold(int count)
    {
        _gold += count;
    }

    public int GetGold()
    {
        return _gold;
    }

    public float GetDamage()
    {
        return _damage;
    }

    public float GetHealth()
    {
        return _health;
    }

    private void Death()
    {
        PlayerAnimations.animations.Die();
        GetComponent<PlayerAttacks>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
    }
}
