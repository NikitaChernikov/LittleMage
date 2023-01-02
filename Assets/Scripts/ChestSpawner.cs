using UnityEngine;
using System.Collections;

public class ChestSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _chestPrefab;
    [SerializeField] private Vector3 _spawnRange;

    private float x;
    private float z;

    private void Start()
    {
        StartCoroutine(SpawnChest());
    }

    private IEnumerator SpawnChest()
    {
        while (PlayerStats.stats.GetHealth() > 0)
        {
            yield return new WaitForSeconds(5);
            x = Random.Range(-_spawnRange.x, _spawnRange.x);
            z = Random.Range(-_spawnRange.z, _spawnRange.z);
            Instantiate(_chestPrefab, transform.position + new Vector3(x, 0, z), _chestPrefab.transform.rotation); 
        }
    }
}
