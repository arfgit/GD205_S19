using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class MyNavAgent : MonoBehaviour
{
   
    NavMeshAgent nav;
    public Transform target;


    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
       nav.SetDestination(target.transform.position);
    }

   /*  void OnTriggerStay(Collider other)
    {
        Debug.Log("your trigger hit... " + other.name);
        if (other.gameObject.CompareTag("Player"))
        {
            nav.destination = other.transform.position;
        }
    } */

    

}
