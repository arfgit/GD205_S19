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
            
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnim.SetInteger("state", 1);

        }
    }

    }
    

