using UnityEngine;

public class Buffs : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var tag = this.tag;
            switch (tag)
            {
                case "Gold":
                    PlayerStats.stats.AddGold(50);
                    Destroy(this.gameObject);
                    break;
                case "HP":
                    PlayerStats.stats.AddHealth();
                    Destroy(this.gameObject);
                    break;
                case "Armour":
                    PlayerStats.stats.AddArmour();
                    Destroy(this.gameObject);
                    break;
            }
        }
    }
}
