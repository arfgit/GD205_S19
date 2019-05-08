using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed; //controls the speed in which the character moves
    private Rigidbody2D myRb;
    private Vector3 change; //effects players position
        void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        change = Vector3.zero; //every frame resets the change
        change.x = Input.GetAxisRaw("Horizontal"); //returns the value of the virtual axis indentified by horizontal value. No smoothing filter.
        change.y = Input.GetAxisRaw("Vertical"); //returns the value of the virtual axis indentified by vertical value. No smoothing filter.
        Debug.Log(change);

        //if there is a change happening in the variable then move the player
        if(change !=Vector3.zero){
            MovePlayer();

        }


    }

    void MovePlayer()
    {

        myRb.MovePosition(transform.position + change * speed * Time.deltaTime); //moving a small amount each frame


    }
}
