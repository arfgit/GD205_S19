using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCam : MonoBehaviour
{
  Vector3 cameraDirection;


  void Update()
  {
      cameraDirection = Camera.main.transform.forward; //indicates where the camera is facing
      cameraDirection.y = 0;
      transform.rotation = Quaternion.LookRotation(cameraDirection);

  }
}
