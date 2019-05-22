using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinFP : MonoBehaviour
{
     void OnCollisionEnter(Collision other){
        if (gameObject.name == "Player") 
        {
        SceneManager.LoadScene("WinFP");
        }
      
    }
}
