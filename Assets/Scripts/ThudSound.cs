using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThudSound : MonoBehaviour
{
    public AudioSource thud;
    
    // when we enter collision check if it's tagged ground
    void OnCollisionEnter(Collision collision){
        // if so play thud clip
        if(collision.gameObject.tag == "ground"){
            thud.Play();
        }
    }
}
