using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser2D : MonoBehaviour
{
    public Camera cam;

   public float boomAMT = 10f;
     public AudioSource soundEffect;

     GameObject target;
     GameObject bomb;


     void Start(){

         target = GameObject.FindGameObjectWithTag("Good");
         bomb = GameObject.FindGameObjectWithTag("Bad");

     }
    void Update()
    {
        Raycast();
              if (Input.GetKeyDown(KeyCode.Mouse0))
             {
                 soundEffect.Play();
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
     if(bomb == null){
        SceneManager.LoadScene("WinCarv");

     }


    }

}

    

