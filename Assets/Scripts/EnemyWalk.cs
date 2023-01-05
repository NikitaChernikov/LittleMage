using UnityEngine;
using UnityEngine.AI;

public class EnemyWalk : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Transform _player;
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _agent = GetComponent<NavMeshAgent>();
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, _player.position) < 3)
        {
            transform.LookAt(_player);
            _agent.isStopped = true;
            _anim.SetBool("Attack", true);
        }
        else
        {
            _anim.SetBool("Attack", false);
            _agent.isStopped = false;
            _agent.SetDestination(_player.position);
        }
        
    }
}
