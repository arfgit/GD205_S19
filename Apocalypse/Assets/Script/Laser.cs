using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float boomAMT = 10f;
    public AudioClip soundEffect;
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.origin, laser.direction, Color.green);
        if(Physics.Raycast(laser, out hit, 10000f))
        {
            if(hit.rigidbody)
            {
                if(Input.GetKeyDown(KeyCode.Mouse0))
                {
                hit.rigidbody.AddForce(Random.insideUnitSphere * boomAMT);
                }
            }
            Debug.Log("you hit something ... " + hit.transform.gameObject.name);
            }

        }

    }
   


