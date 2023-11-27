using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float lookRadius = 50f;

    public Transform target;
    private NavMeshAgent agent;
    public GameObject Player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(transform.position, target.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.transform.position);
        }
    }
}