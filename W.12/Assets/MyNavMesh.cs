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
        //nav.destination = target.transform.position;


    }

    void OnTriggerStay(Collider other){
        Debug.Log("your trigger hit..." + other.name);
            if(other.gameObject.CompareTag("Player")){
                nav.destination = other.transform.position;


        }



    }
}
