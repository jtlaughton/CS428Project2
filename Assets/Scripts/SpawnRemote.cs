using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Data.Collection.List;

public class SpawnRemote : MonoBehaviour
{
    public GameObject currentRemote;
    public GameObjectObservableList current_ignored;

    public void spawnNewRemote(){
        // only spawn when not grabbed
        if(!GrabbedManager.Instance.remoteGrabbed){
            // create new object
            GameObject newRemote = GameObject.Instantiate(currentRemote);
            // set its transform
            newRemote.transform.position = gameObject.transform.position;
            // remove from ignored list
            current_ignored.Remove(currentRemote);
            // destoy old one
            Destroy(currentRemote);
            // update current
            currentRemote = newRemote;
        }
    }
}
