using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform target; // Asigna el objetivo desde el inspector

    private NavMeshAgent agent;

    void Start()
    {
        // Obtiene el componente NavMeshAgent
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
