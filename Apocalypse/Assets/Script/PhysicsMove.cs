using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhysicsMove : MonoBehaviour
{
   Rigidbody myRb;
   int victimEaten = 1;
   public int eatThresh = 3;
   public float multiplier = 10f;
	// Use this for initialization
	void Start () {
        myRb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W)){
            //add force to our rigidbody
            //in the direction (0,1,0) (up)
            //multiplied times a force amount
            myRb.AddForce(new Vector3(0f, 0f, 1f) * multiplier);
        }
	
        if (Input.GetKey(KeyCode.S)){
            //add force to our rigidbody
            //in the direction (0,1,0) (up)
            //multiplied times a force amount
            myRb.AddForce(new Vector3(0, 0f, -1f) * multiplier);
        }
        if (Input.GetKey(KeyCode.A)){
            //add force to our rigidbody
            //in the direction (0,1,0) (up)
            //multiplied times a force amount
            myRb.AddForce(new Vector3(-1, 0f, 0f) * multiplier);
        }
        if (Input.GetKey(KeyCode.D)){
            //add force to our rigidbody
            //in the direction (0,1,0) (up)
            //multiplied times a force amount
            myRb.AddForce(new Vector3(1, 0f, 0f) * multiplier);
        }

}
    void OnCollisionEnter(Collision col)
    {
        //we compare the transform of the thing that collided with us to the predator
        if (col.gameObject.CompareTag("Prey"))
        {
                victimEaten++;
            Destroy(col.gameObject); 
            
            if(victimEaten < eatThresh){
                    //Destroy(gameObject);
                transform.localScale += new Vector3(1f, 1f, 1f);

            }
        }
        if(col.gameObject.CompareTag("Pred")){
                 Destroy(gameObject);
                 SceneManager.LoadScene("GameOver");
                }

            }

            
    void OnTriggerEnter(Collider other){
      if (other.tag == "Pred"){
        SceneManager.LoadScene("GameOver");
      }
    }
    


        
        
}



