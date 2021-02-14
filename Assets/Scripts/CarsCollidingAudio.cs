using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsCollidingAudio : MonoBehaviour
{
    public AudioClip carCrash;
    public static bool carCrashed = false;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = carCrash;
        audioSource.time = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (carCrashed == true)
        {
            GetComponent<AudioSource>().Play();
            carCrashed = false;
        }
    }
}
