using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Data.Collection.List;

public class SpawnFlashLight : MonoBehaviour
{
    public GameObject currentFlashLight;
    public GameObjectObservableList current_ignored;

    public void spawnNewFlash(){
        // only spawn when not grabbed
        if(!GrabbedManager.Instance.flashLightGrabbed){
            // create new object
            GameObject newFlash = GameObject.Instantiate(currentFlashLight);
            // set its transform
            newFlash.transform.position = gameObject.transform.position;
            // remove from ignored list
            current_ignored.Remove(currentFlashLight);
            // destoy old one
            Destroy(currentFlashLight);
            // update current
            currentFlashLight = newFlash;
        }
    }
}
