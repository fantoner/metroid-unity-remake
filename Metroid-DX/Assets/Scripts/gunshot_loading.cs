using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshot_loading : MonoBehaviour
{
    float counter = 0;
    private AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    
    void Update() 
    {
		if (Input.GetButton("Fire1")) {
		counter += Time.deltaTime;
}
        // When spacebar is hit
         if (counter == 1)  
        {
            // instantiate the fireball object
            
            // play the sound
            source.Play();
			counter = 0;
        }
    }

}