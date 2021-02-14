using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioClip coinPickup;
    public static bool coinPickedUp = false;
    public AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = coinPickup;
        audioSource.time = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (coinPickedUp == true)
        {
            GetComponent<AudioSource>().Play();
            coinPickedUp = false;
        }


        
    }
}
