using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public int whichScene = 0;

    public GameObject[] worlds = new GameObject[5];
    public bool[] occulsionOn = new bool[5];
    public bool[] worldOn = new bool[5];

    public GameObject environment;
    public GameObject occulsion;
    public Camera _camera;
    public Camera _ipadcamera;
    // Start is called before the first frame update
    void Start()
    {
        initWorld();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            nextWorld();
        }


        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            nextWorld();
        }
    }

    void initWorld()
    {
        for (int i= 0; i < worlds.Length; i++)
        {
            worlds[i].SetActive(false);
        }
        worlds[whichScene].SetActive(true);
        environment.SetActive(worldOn[whichScene]);
        SwitchOcculsion(occulsionOn[whichScene]);
    }

    void nextWorld()
    {
        whichScene += 1;
        if (whichScene >= worlds.Length)
        {
            whichScene = 0;
        }
        initWorld();
    }

    void SwitchOcculsion(bool OcclusionOn)
    {
      if (OcclusionOn)
        {
            _ipadcamera.cullingMask |= 1 << LayerMask.NameToLayer("Occlusion");
        }
        else
        {
            _ipadcamera.cullingMask &= ~(1 << LayerMask.NameToLayer("Occlusion"));
        }
    }
}
