using UnityEngine;

public class WorldController : MonoBehaviour
{   
    public GameObject environment;
    public Camera mainCamera;
    public Camera screenCamera;
    public World[] worlds;
    public int currentWorldIndex = 0;
    public World currentWorld;

    private void Start()
    {
        environment = GameObject.FindGameObjectWithTag("Environment").GetComponent<GameObject>();
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        screenCamera = GameObject.FindGameObjectWithTag("ScreenCamera").GetComponent<Camera>();
        InitializeWorlds();
        SetCurrentWorld(currentWorldIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            NextWorld();
        }
    }

    public void SetCurrentWorld(int index)
    {
        currentWorld = worlds[index];
        currentWorldIndex = index;

        for (int i = 0; i < worlds.Length; i++)
        {
            worlds[i].worldObject.SetActive(false);
        }

        for (int i = 0; i < worlds.Length; i++)
        {
            if (currentWorld == worlds[i])
            {
                worlds[i].worldObject.SetActive(true);
            }
        }
    }

    public void InitializeWorlds()
    {
        for (int i = 0; i < worlds.Length; i++)
        {
            World worldToSetup = worlds[i];
            GameObject worldObjectToSetup = worldToSetup.worldObject;
            int layerIndex = worldToSetup.occlusionEnabled ? 6 : 0;
            SetOcclusionLayerRecursively(worldObjectToSetup, layerIndex);
        }
    }

    public void SetOcclusionLayerRecursively(GameObject obj, int layerIndex)
    {
        obj.layer = layerIndex;
        foreach (Transform child in obj.transform)
        {
            if (null == child)
            {
                continue;
            }
            SetOcclusionLayerRecursively(child.gameObject, layerIndex);
        }
    }

    public void SetCurrentWorldOcclusion(bool state)
    {
        currentWorld.occlusionEnabled = state;
        int layerIndex = currentWorld.occlusionEnabled ? 6 : 0;
        SetOcclusionLayerRecursively(currentWorld.worldObject, layerIndex);
    }

    public void NextWorld()
    {
        currentWorldIndex += 1;
        if(currentWorldIndex >= worlds.Length)
        {
            SetCurrentWorld(0);
        }
        else
        {
            SetCurrentWorld(currentWorldIndex);
        }
    }
}
