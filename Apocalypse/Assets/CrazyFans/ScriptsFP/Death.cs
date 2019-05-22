using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
  void OnTriggerEnter(Collider other){
      if(other.tag == "Finish")
      {
        SceneManager.LoadScene("WinFP");

      }
    }
    void OnCollisionEnter(Collision col){
    if ((col.gameObject.tag == "Bad"))
        {
        SceneManager.LoadScene("LoseFP");
      }

    }
}
            

