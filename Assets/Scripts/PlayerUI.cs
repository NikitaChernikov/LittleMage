using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private Slider _armourSlider;
    [SerializeField] private Text _goldText;

    public void ChangeHealthSlider(float health)
    {
        _healthSlider.value = health;
    }

    public void ChangeGoldValue(int gold)
    {
        _goldText.text = gold.ToString();
    }

    public void ChangeArmourSlider(float armour)
    {
        _armourSlider.value = armour;
    }
}
