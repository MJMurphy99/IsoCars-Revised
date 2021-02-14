using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeathManagerScript : MonoBehaviour
{

    public AudioClip playerDeath;
    public static bool playerDied = false;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = playerDeath;
        audioSource.time = 0.50f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDied == true)
        {

            GetComponent<AudioSource>().Play();
            playerDied = false;
        }
    }
}
