using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
  

    private NavMeshAgent agent;

    void Start()
    {
      
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Establece el destino del agente al objetivo
        if (target != null)
        {
            agent.SetDestination(target.position);
           
        }
    }
}
