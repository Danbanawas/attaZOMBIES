using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombiemove : MonoBehaviour
{
    public Transform player;
    public float distancefollowed = 280f;
    private NavMeshAgent agent;
    public Animator anim;
    
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();  
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance=Vector3.Distance(transform.position, player.position);
        if (distance<= distancefollowed) {
            
            agent.SetDestination(player.position);
            runs();
            agent.autoRepath = true;
            

        }
        void runs()
        {
            anim.SetBool("runto", false);
            anim.SetTrigger("runit");
           
        }
       
    }
}
