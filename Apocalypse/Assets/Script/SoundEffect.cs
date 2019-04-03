using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
       public AudioSource sound;
       
    void Update()
    {
          if (Input.GetMouseButtonDown(0) == true)
             {
                 sound.Play();
             }
             if (Input.GetMouseButtonUp(0) == true)
             {
                sound.Stop();
             }
    }

}
