using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOnScoreText : MonoBehaviour
{

    public bool collisionHappened = false;
    public float displayTimer;
    public Text scoreIncrease;

    public AudioClip playerMadeIt;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        scoreIncrease.gameObject.SetActive(false);
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = playerMadeIt;
        audioSource.time = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        displayTimer -= Time.deltaTime;
        if (collisionHappened == true)
        {
            scoreIncrease.gameObject.SetActive(true);
            if (displayTimer < 0)
            {
                collisionHappened = false;
                scoreIncrease.gameObject.SetActive(false);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pedestrianPrefab")
        {
            GetComponent<AudioSource>().Play();
            collisionHappened = true;
            displayTimer = 1;
        }
    }
}
