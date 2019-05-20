using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attaches the component placed ot the character
[RequireComponent(typeof(CharacterController))]
public class MovementFP : MonoBehaviour
{
    // variables //
     public float playerWalkingSpeed = 5f; //controls player walking speed
    public float playerRunningSpeed = 10f; //controls players running speed
    public float jumpStrength = 5f; //controls player 
    public float verticalRotationLimit = 80f; //limits how high the person can look up and down on the vertical axis
    
    float fowardMovement; //foward
    float sidewaysMovement; //sideways

    float verticalJump; //jump height

    
    
    float verticalRotation = 0;
    CharacterController cc;

    void Awake() //initializes variables beofre the game starts
    {
        cc= GetComponent<CharacterController>();
        Cursor.visible = false; //hides the cursor once i hit play
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        //mouse camera movement
           
            //horizontal camera movement
        float horizontalRotation = Input.GetAxis("Mouse X");
        transform.Rotate(0, horizontalRotation, 0);
           
            //vertical camera movement
                //how high and low the player can look has been limited.
        if(cc.isGrounded){
        verticalRotation -= Input.GetAxis("Mouse Y");
        verticalRotation = Mathf.Clamp(verticalRotation, -verticalRotationLimit, verticalRotationLimit); //(vairable we want to control, first value, second value)
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0 ,0);

        //foward movement for walk
        fowardMovement = Input.GetAxis("Vertical") * playerWalkingSpeed;

        //sideways movement for walk
        sidewaysMovement = Input.GetAxis("Horizontal") * playerWalkingSpeed;

        if(Input.GetKey(KeyCode.LeftShift))
            {
        //foward movement for run
        fowardMovement = Input.GetAxis("Vertical") * playerRunningSpeed;

        //sideways movement for run
        sidewaysMovement = Input.GetAxis("Horizontal") * playerRunningSpeed;

            }
        }
        

        verticalJump += Physics.gravity.y * Time.deltaTime;



          if(Input.GetButton("Jump") && cc.isGrounded)
        {
            verticalJump = jumpStrength;

        }

        //x = sideways movement, y = jump, z = foward movement
        Vector3 playerMovement = new Vector3
        (sidewaysMovement, verticalJump, fowardMovement);


        
        //moves the controller by motion
        cc.Move(transform.rotation * playerMovement * Time.deltaTime);

    }
}
