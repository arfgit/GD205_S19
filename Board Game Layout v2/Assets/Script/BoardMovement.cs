using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour {
	Vector3 playerPos;  //x, y , and z axis for the player
	public Transform destination; //select the victory tile
	public Transform hazard; //select the hazard tiles
	public Transform block; //select the blockades

	// Use this for initialization
	  void Start () {
        playerPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        //4 directional board movement
        if (Input.GetKeyDown(KeyCode.W)) //move plauer up
        {
            playerPos += transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.S)) //move player down
        {
            playerPos -= transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.D)) //move player right
        {
            playerPos += transform.right;
        }
        if (Input.GetKeyDown(KeyCode.A)) //move player left
        {
            playerPos -= transform.right;
        }

        //check if the players x and z position is the same as the destination
        if (playerPos.x == destination.position.x && 
            playerPos.z == destination.position.z){
            playerPos -= transform.up;
        }
        //check if player x/z same as hazard
        if (playerPos.x == hazard.position.x &&
            playerPos.z == hazard.position.z)
        {
            playerPos -= transform.up;
        }
		if (playerPos.x == block.position.x &&
            playerPos.z == block.position.z){

			playerPos += transform.up;
			}

        //update the position of the gameobject this is attached to
        transform.position = playerPos;
    }
}