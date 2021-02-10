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
            float randomTime = Random.Range(5f, 6f);

            if (PedestrianScript.roadRedBool == false)
            {
                GameObject newPedestrian = (GameObject)Instantiate(pedestrianPrefab);
                newPedestrian.transform.position = transform.position;
                newPedestrian.GetComponent<PedestrianScript>().SetDirection(transform.forward);
            }
            if (RestartScene.gameTimer >= 45f)
            {
                randomTime = Random.Range(4f, 5f);
            }
            else if (RestartScene.gameTimer <= 45f && RestartScene.gameTimer >= 25f)
            {
                randomTime = Random.Range(3f, 4f);
            }
            else if (RestartScene.gameTimer <= 25f)
            {
                randomTime = Random.Range(2f, 3f);
            }

            Invoke("CreateNewObject", randomTime);
        
    }
}
