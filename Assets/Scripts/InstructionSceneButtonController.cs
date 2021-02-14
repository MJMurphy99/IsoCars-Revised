using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionSceneButtonController : MonoBehaviour
{
    public GameObject carSpawners;
    public static bool carsCanSpawn;
    // Start is called before the first frame update
    void Start()
    {
        carSpawners.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCars()
    {
        if(carSpawners.activeSelf == false)
        {
            carSpawners.SetActive(true);
            carsCanSpawn = true;
        }
        else
        {
            carSpawners.SetActive(false);
            carsCanSpawn = false;
        }
    }
}
