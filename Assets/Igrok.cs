using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Igrok : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent _agent;
    private Animator anim;
    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

  
    
     
    

    void Update()
    {
        _agent.SetDestination(target.position);
        anim.SetFloat("Speed",_agent.velocity.magnitude);
    }
}
