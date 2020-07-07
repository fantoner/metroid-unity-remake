using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshot : MonoBehaviour
{
    
    private AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    
    void Update() 
    {
        // When spacebar is hit
         if (Input.GetMouseButtonDown(0))  
        {
            // instantiate the fireball object
            
            // play the sound
            source.Play();
        }
    }

}