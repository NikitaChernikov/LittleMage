using UnityEngine;
using System.Collections;

public class BuffChest : MonoBehaviour
{
    [SerializeField] private GameObject _gold;
    [SerializeField] private GameObject _health;
    [SerializeField] private GameObject _armour;

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        StartCoroutine(DestroyChest());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("Open");
            Invoke("ChooseBuff", 1);
        }
    }

    private void ChooseBuff()
    {
        float x = Random.Range(0, 3);
        switch (x)
        {
            case 0:
                _gold.SetActive(true);
                break;
            case 1:
                _health.SetActive(true);
                break;
            case 2:
                _armour.SetActive(true);
                break;
        }
    }

    private IEnumerator DestroyChest()
    {
        yield return new WaitForSeconds(30);
        anim.SetTrigger("Destroy");
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
