using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float RotateSpeed = 2.0f;
  

   
    void Update()
    {
        this.transform.Rotate(0, RotateSpeed, 0);
    }
}
