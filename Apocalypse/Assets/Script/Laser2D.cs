using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser2D : MonoBehaviour
{
    public Camera cam;

   public float boomAMT = 10f;
    public AudioClip soundEffect;
    void Update()
    {
        Raycast();

             if (Input.GetMouseButtonDown(0) == true)
             {
                 soundEffect.Play();
             }
             if (Input.GetMouseButtonUp(0) == true)
             {
                soundEffect.Stop();
             }

        }
    void Raycast(){
        Vector3 mousePos= Input.mousePosition;
        mousePos.z=10;
        Vector3 screenPos = cam.ScreenToWorldPoint(mousePos);
        RaycastHit2D hit=Physics2D.Raycast(screenPos, Vector2.zero);
      if (Input.GetKeyDown(KeyCode.Mouse0)) {
        Debug.Log ("I hit " + hit.collider.gameObject.name);
        Destroy(GameObject.Find(hit.collider.gameObject.name));
        } else 
        {
        Debug.Log ("I hit nothing");
        }


    }

    void OnCollisionEnter2D(Collision2D col){


    }
}

    

