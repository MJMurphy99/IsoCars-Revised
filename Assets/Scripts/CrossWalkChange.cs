using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossWalkChange : MonoBehaviour
{
    public Material GoRoadColor, StopRoadColor, SlowRoadColor;
    public Renderer Road;
    public float colorTimer = 25f;
    void Start()
    {
        Road.material = GoRoadColor;
    }

    void Update()
    {
        colorTimer -= Time.deltaTime;
        if (colorTimer <= 10 && colorTimer >= 0)
        {
            PedestrianScript.roadRedBool = true;
            PedestrianScript.roadYellowBool = false;
            Road.material = StopRoadColor;
        } else if (colorTimer > 15)
        {
            PedestrianScript.roadRedBool = false;
            PedestrianScript.roadYellowBool = false;
            Road.material = GoRoadColor;
        } else if (colorTimer <= 15 && colorTimer > 10)
        {
            PedestrianScript.roadRedBool = false;
            PedestrianScript.roadYellowBool = true;
            Road.material = SlowRoadColor;
        }


        if (colorTimer < 0)
        {
            colorTimer = 25f;
        }
    }

}
