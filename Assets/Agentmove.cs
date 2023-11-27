using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agentmove : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform Player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.autoRepath = true;
        agent.SetDestination(Player.position);
        //if (Input.GetMouseButtonDown(0))
       // {
          //  RaycastHit hit;

          //  if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
          //  {
               // agent.destination = hit.point;
            //}
        //}

    }
}

