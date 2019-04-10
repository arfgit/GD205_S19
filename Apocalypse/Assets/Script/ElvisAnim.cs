using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElvisAnim : MonoBehaviour
{
    Animator myAnim;

    void Start()
    {

    myAnim = GetComponent<Animator>();

    }


    void Update()
    {
        
        myAnim.SetInteger("state", 0);
        if(Input.GetKey(KeyCode.W))
            {
            myAnim.SetInteger("state", 1);

            }
         
         myAnim.SetInteger("jump", 0);
        if (Input.GetKeyDown(KeyCode.Space))
            {
            myAnim.SetInteger("jump", 1);

            }
         myAnim.SetInteger("run", 0);
        if (Input.GetKey(KeyCode.LeftShift))
            {
            myAnim.SetInteger("run", 1);
            }
              myAnim.SetInteger("rightTurn", 0);
        if (Input.GetKey(KeyCode.E))
            {
            myAnim.SetInteger("rightTurn", 1);
            }
                   myAnim.SetInteger("leftTurn", 0);
        if (Input.GetKeyDown(KeyCode.Q))
            {
            myAnim.SetInteger("leftTurn", 1);
            }
    }

    }
    

