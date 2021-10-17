using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Data.Collection.List;

public class AddToObservable : MonoBehaviour
{

    public GameObjectObservableList current_ignored;

    // Start is called before the first frame update
    void Start()
    {
        // on startup add itself ignored list
        current_ignored.Add(gameObject);
    }
}
