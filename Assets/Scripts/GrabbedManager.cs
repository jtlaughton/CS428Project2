using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class to keep track of what items are being held in the scene
public class GrabbedManager : MonoBehaviour
{
    // create a singleton
    public static GrabbedManager Instance {get; private set;}

    // booleans to track which objects are grabbed
    public bool flashLightGrabbed = false;
    public bool remoteGrabbed = false;
    public bool phoneGrabbed = false;

    // assign singleton
    void Start(){
        Instance = this;
    }

    // set flashLightGrabbed to true
    public void activateFlashGrab(){
        flashLightGrabbed = true;
    }

    // set flashLightGrabbed to false
    public void deactivateFlashGrab(){
        flashLightGrabbed = false;
    }

    // set remoteGrabbed to true
    public void activateRemoteGrab(){
        remoteGrabbed = true;
    }

    // set remoteGrabbed to false
    public void deactivateRemoteGrab(){
        remoteGrabbed = false;
    }

    // set phoneGrabbed to true
    public void activatePhoneGrab(){
        phoneGrabbed = true;
    }

    // set phoneGrabbed to false
    public void deactivatePhoneGrab(){
        phoneGrabbed = false;
    }
}
