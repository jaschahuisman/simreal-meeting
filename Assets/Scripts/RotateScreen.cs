using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScreen : MonoBehaviour
{
    public float RotateSpeed = 10.0f;

    void Update()
    {
        this.transform.Rotate(0, RotateSpeed * Time.deltaTime, 0);
    }
}