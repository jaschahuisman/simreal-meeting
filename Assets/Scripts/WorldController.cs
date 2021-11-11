using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public GameObject world;
    public GameObject environment;
    public Camera screenCamera;

    void Start()
    {
        world = GameObject.FindGameObjectWithTag("World").GetComponent<GameObject>();
        environment = GameObject.FindGameObjectWithTag("Environment").GetComponent<GameObject>();
        screenCamera = GameObject.FindGameObjectWithTag("ScreenCamera").GetComponent<Camera>();
    }
}
