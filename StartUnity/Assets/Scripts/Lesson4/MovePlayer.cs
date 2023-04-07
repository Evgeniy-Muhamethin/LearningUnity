using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private Transform _point;
    [SerializeField]
    private NavMeshAgent _agent;

    void Update()
    {
        _agent.SetDestination(_point.transform.position);
    }
}
