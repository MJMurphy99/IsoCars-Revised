using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossWalkChange : MonoBehaviour
{
    public Material GoRoadColor, StopRoadColor;
    public Renderer Road;
    public float colorTimer = 20f;
    public bool roadColorBool = false;
    void Start()
    {
        Road.material = GoRoadColor;
    }

    void Update()
    {
        colorTimer -= Time.deltaTime;
        if (colorTimer <= 10 && colorTimer >= 0)
        {
            Road.material = StopRoadColor;
        } else if (colorTimer < 0)
        {
            Road.material = GoRoadColor;
            colorTimer = 20f;
        }
    }

}
