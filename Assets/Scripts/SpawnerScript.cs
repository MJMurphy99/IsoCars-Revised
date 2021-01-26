using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject carPrefab, pickupPrefab;

    void Start()
    {
        CreateNewObject();
    }

    void CreateNewObject()
    {
        int whichObject = Random.Range(0, 10);
        float randomTime = Random.Range(4f, 6f);

        if (whichObject <= 7)
        {
            GameObject newCar = (GameObject)Instantiate(carPrefab);
            newCar.transform.position = transform.position;
            newCar.GetComponent<CarScript>().SetDirection(transform.forward);
        } else
        {
            GameObject newPickup = (GameObject)Instantiate(pickupPrefab);
            newPickup.transform.position = transform.position;
            newPickup.GetComponent<PickupScript>().SetDirection(transform.forward);
        }

        if (RestartScene.gameTimer >= 45f)
        {
            randomTime = Random.Range(4f, 6f);
        }
        else if (RestartScene.gameTimer <= 45f && RestartScene.gameTimer >= 25f)
        {
            randomTime = Random.Range(3f, 4f);
        }
        else if (RestartScene.gameTimer <= 25f)
        {
            randomTime = Random.Range(2.5f, 3f);
        }


        Invoke("CreateNewObject", randomTime);
    }
}
