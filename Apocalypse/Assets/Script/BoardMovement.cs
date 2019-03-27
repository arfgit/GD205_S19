using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour {
	 Vector3 playerPos;
    Vector3 startPos;
    public Transform destination;


    GameObject[] hazards;
    GameObject[] blocks;


    public TextMesh playerMessage;

  
    void Start () {
 
        playerPos = transform.position;

 
        startPos = playerPos;

        hazards = GameObject.FindGameObjectsWithTag("Hazard");
        blocks = GameObject.FindGameObjectsWithTag("Block");

    }
	

	void Update () {
	
        Vector3 newPos = playerPos;

   
        if (Input.GetKeyDown(KeyCode.W))
        {
        
            newPos = playerPos + transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
      
            newPos = playerPos - transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
   
            newPos = playerPos + transform.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
        
            newPos = playerPos - transform.right;
        }


     
        bool inABlock = false;

      
        for (int i = 0; i < blocks.Length; i++)
        {	
     
            if (newPos.x == blocks[i].transform.position.x &&
                newPos.z == blocks[i].transform.position.z)
            {
           
                inABlock = true;
            }
        }
      
        if (!inABlock) {
        	playerPos = newPos;
        }


   
       for (int i = 0; i < hazards.Length; i++){
       
            if (playerPos.x == hazards[i].transform.position.x &&
                    playerPos.z == hazards[i].transform.position.z)
            {
            	
                playerPos = startPos;
             
                playerMessage.text = "nice try";
            }
        }


        if (playerPos.x == destination.position.x && 
            playerPos.z == destination.position.z){
            playerPos += transform.up;
        }


     
        transform.position = playerPos;
    }
}

