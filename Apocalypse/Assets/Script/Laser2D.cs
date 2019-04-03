using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser2D : MonoBehaviour
{
    public Camera cam;

   public float boomAMT = 10f;
     public AudioSource soundEffect;
     public AudioSource bombEffect;

     GameObject target;
     GameObject bomb;

     public float numberTarget = 1f;
     public float targetThresh = 5f;


     void Start(){

         target = GameObject.FindGameObjectWithTag("Good");
         bomb = GameObject.FindGameObjectWithTag("Pred");

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
        if(target == null){
            
            numberTarget++;

        if(numberTarget == targetThresh){
        SceneManager.LoadScene("WinCarv");

        }
     }
        if(bomb == null){
         SceneManager.LoadScene("GameOverCarv");

     }




    }

}

    

