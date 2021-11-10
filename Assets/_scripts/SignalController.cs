using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalController : MonoBehaviour
{

    public GameObject ipad;
    public GameObject scanRuimte;
    public GameObject modelRuimte;
    public GameObject scherm;
    public GameObject worlds;
    public GameObject personen;

    public Camera _camera;
    public Camera _ipadcamera;

    // Start is called before the first frame update
    void Start()
    {
       HideAll();
       
    }

    // Update is called once per frame
    void HideAll()
    {
        ipad.SetActive(false);
        scanRuimte.SetActive(false);
        modelRuimte.SetActive(false);
        scherm.SetActive(false);
        worlds.SetActive(false);
        personen.SetActive(false);

        BeeldUit();
    }

    public void BeeldVertoond()
    {
     _ipadcamera.cullingMask |= 1 << LayerMask.NameToLayer("Occlusion");
        _ipadcamera.cullingMask |= 1 << LayerMask.NameToLayer("Werelden");


    }


    public void BeeldUit()
    {
     _ipadcamera.cullingMask &= ~(1 << LayerMask.NameToLayer("Occlusion"));
        _ipadcamera.cullingMask &= ~(1 << LayerMask.NameToLayer("Werelden"));


    }


    public void PersonenAan()
    {
        personen.SetActive(true);
    }

  

    public void Elementeninderuimte()
    {
        //  _camera.cullingMask = (1 << LayerMask.NameToLayer("EnvironmentMetPilaren")) | (1 << LayerMask.NameToLayer("Werelden")) | (1 << LayerMask.NameToLayer("Occlusion")); //
        _camera.cullingMask |= 1 << LayerMask.NameToLayer("Werelden");

        //show
        //   camera.cullingMask |= 1 << LayerMask.NameToLayer("SomeLayer");
        // hide
        //    camera.cullingMask &= ~(1 << LayerMask.NameToLayer("SomeLayer"));

    }

    public void ElementenUit()
    {
        // _camera.cullingMask = ((1 << LayerMask.NameToLayer("Werelden")) | (1 << LayerMask.NameToLayer("Occlusion")));
        _camera.cullingMask &= ~(1 << LayerMask.NameToLayer("Werelden"));
    }

    public void IpadAan()
    {
        ipad.SetActive(true);
    }

    public void Moddel()
    {
        modelRuimte.SetActive(true);
        scanRuimte.SetActive(false);
    }

    public void Scan()
    {
        modelRuimte.SetActive(false);
        scanRuimte.SetActive(true);
    }

    public void VirtuleContect()
    {
        worlds.SetActive(true);

    }

    public void RuimteAan()
    {
        //scanRuimte.SetActive(true);
        modelRuimte.SetActive(true);
    }

    public void SchermAan()
    {
        scherm.SetActive(true);
    }

}
