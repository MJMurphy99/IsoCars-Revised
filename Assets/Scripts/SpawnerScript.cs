using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject carPrefab1, pickupPrefab, carPrefab2, carPrefab3, truckPrefab1, truckPrefab2, truckPrefab3;

    void Start()
    {
        CreateNewObject();
    }

    void CreateNewObject()
    {
        int whichObject = Random.Range(0, 8);
        float randomTime = Random.Range(5f, 8f);

        if (whichObject <= 1)
        {
            GameObject newCar = (GameObject)Instantiate(carPrefab1);
            newCar.transform.position = transform.position;
            newCar.GetComponent<CarScript>().SetDirection(transform.forward);
        } else if (whichObject == 2)
        {
            GameObject newPickup = (GameObject)Instantiate(pickupPrefab);
            newPickup.transform.position = transform.position;
            newPickup.GetComponent<PickupScript>().SetDirection(transform.forward);
        } else if (whichObject >= 3 && whichObject <= 4)
        {
            GameObject newCar = (GameObject)Instantiate(carPrefab2);
            newCar.transform.position = transform.position;
            newCar.GetComponent<CarScript>().SetDirection(transform.forward);
        } else if (whichObject == 5)
        {
            GameObject newCar = (GameObject)Instantiate(carPrefab3);
            newCar.transform.position = transform.position;
            newCar.GetComponent<CarScript>().SetDirection(transform.forward);
        } else if (whichObject == 6)
        {
            GameObject newCar = (GameObject)Instantiate(truckPrefab1);
            newCar.transform.position = transform.position;
            newCar.GetComponent<CarScript>().SetDirection(transform.forward);
        } else if (whichObject == 7)
        {
            GameObject newCar = (GameObject)Instantiate(truckPrefab2);
            newCar.transform.position = transform.position;
            newCar.GetComponent<CarScript>().SetDirection(transform.forward);
        } else if (whichObject == 8)
        {
            GameObject newCar = (GameObject)Instantiate(truckPrefab3);
            newCar.transform.position = transform.position;
            newCar.GetComponent<CarScript>().SetDirection(transform.forward);
        } else
        {
            GameObject newCar = (GameObject)Instantiate(truckPrefab1);
            newCar.transform.position = transform.position;
            newCar.GetComponent<CarScript>().SetDirection(transform.forward);
        }

        if (RestartScene.gameTimer >= 45f)
        {
            randomTime = Random.Range(5f, 8f);
        }
        else if (RestartScene.gameTimer <= 45f && RestartScene.gameTimer >= 25f)
        {
            randomTime = Random.Range(4f, 7f);
        }
        else if (RestartScene.gameTimer <= 25f)
        {
            randomTime = Random.Range(3f, 6f);
        }

        Invoke("CreateNewObject", randomTime);

        
    }
}
