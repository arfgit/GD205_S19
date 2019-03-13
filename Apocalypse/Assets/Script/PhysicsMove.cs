﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMove : MonoBehaviour
{
   Rigidbody myRb;
   public float multiplier = 10f;
	// Use this for initialization
	void Start () {
        myRb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W)){
            //add force to our rigidbody
            //in the direction (0,1,0) (up)
            //multiplied times a force amount
            myRb.AddForce(new Vector3(0f, 0f, 1f) * multiplier);
        }
	
        if (Input.GetKey(KeyCode.S)){
            //add force to our rigidbody
            //in the direction (0,1,0) (up)
            //multiplied times a force amount
            myRb.AddForce(new Vector3(0, 0f, -1f) * multiplier);
        }
        if (Input.GetKey(KeyCode.A)){
            //add force to our rigidbody
            //in the direction (0,1,0) (up)
            //multiplied times a force amount
            myRb.AddForce(new Vector3(-1, 0f, 0f) * multiplier);
        }
        if (Input.GetKey(KeyCode.D)){
            //add force to our rigidbody
            //in the direction (0,1,0) (up)
            //multiplied times a force amount
            myRb.AddForce(new Vector3(1, 0f, 0f) * multiplier);
        }

}
}
