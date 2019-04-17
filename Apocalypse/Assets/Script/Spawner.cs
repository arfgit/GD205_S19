using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject clone;
    public Vector3 spawnLocation;

    void Start()
    {
        
        

    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            
            Instantiate(clone, spawnLocation, Quaternion.identity );


        }


    }
}
