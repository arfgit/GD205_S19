using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MyNavMesh : MonoBehaviour
{
    NavMeshAgent nav;
    public Transform target;
 
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();


    }

 
    void Update()
    {
        nav.destination = target.transform.position;


    }
}
