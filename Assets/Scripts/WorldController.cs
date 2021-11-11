using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public GameObject world;
    public GameObject environment;
    public Camera screenCamera;
    public bool occlusion = true;

    void Start()
    {
        world = GameObject.FindGameObjectWithTag("World").GetComponent<GameObject>();
        environment = GameObject.FindGameObjectWithTag("Environment").GetComponent<GameObject>();
        screenCamera = GameObject.FindGameObjectWithTag("ScreenCamera").GetComponent<Camera>();
    }

    private void initializeWorld()
    {
        world.SetActive(true);
        environment.SetActive(true);
        toggleOcclusion(occlusion);
    }

    public void toggleOcclusion(bool occlusionOn)
    {
        if (occlusionOn)
        {
            screenCamera.cullingMask |= 1 << LayerMask.NameToLayer("Occlusion");
        }
        else
        {
            screenCamera.cullingMask &= ~(1 << LayerMask.NameToLayer("Occlusion"));
        }
    }
}
