using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianSpawner : MonoBehaviour
{
    public GameObject pedestrianPrefab;
    public float safeCrossTimer;
    public bool spawnable;

    void Start()
    {
        CreateNewObject();
    }

    void CreateNewObject()
    {
        int whichObject = 0;
        float randomTime = Random.Range(8f, 15f);

        if (whichObject == 0)
        {
            GameObject newPedestrian = (GameObject)Instantiate(pedestrianPrefab);
            newPedestrian.transform.position = transform.position;
            newPedestrian.GetComponent<PedestrianScript>().SetDirection(transform.forward);
        }
        if (RestartScene.gameTimer >= 45f)
        {
            randomTime = Random.Range(8f, 15f);
        } else if (RestartScene.gameTimer <= 45f && RestartScene.gameTimer >= 25f)
        {
            randomTime = Random.Range(5f, 8f);
        } else if (RestartScene.gameTimer <= 25f)
        {
            randomTime = Random.Range(2f, 5f);
        }
        
        Invoke("CreateNewObject", randomTime);
    }
}
