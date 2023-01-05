using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats stats;

    private PlayerUI playerUI;
    private float _armour = 1;
    private float _health = 100;
    private float _damage = 10;
    private int _gold = 0;
    private int percentageConverter = 100;

    private void Awake()
    {
        stats = this;
        playerUI = GetComponent<PlayerUI>();
    }

    private void Start()
    {
        playerUI.ChangeHealthSlider(_health);
        playerUI.ChangeGoldValue(_gold);
        playerUI.ChangeArmourSlider(_armour);
    }

    public void TakeDamage(float amount)
    {
        amount -= (amount * _armour / percentageConverter);
        _health -= amount;
        playerUI.ChangeHealthSlider(_health);
        if (_health <= 0)
        {
            Death();
        }
    }

    public void AddHealth()
    {
        if (_health >= 91) _health = 100;
        else _health += 10;
        playerUI.ChangeHealthSlider(_health);
    }

    public void AddArmour()
    {
        if (_armour >= 50)
        {
            _armour = 50;
            return;
        }
        _armour *= 1.5f;
        playerUI.ChangeArmourSlider(_armour);
    }

    public void AddGold(int count)
    {
        _gold += count;
        playerUI.ChangeGoldValue(_gold);
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
