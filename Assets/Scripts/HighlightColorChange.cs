using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightColorChange : MonoBehaviour
{
    public Color baseColor;
    public Color hoverColor;
    public bool mouseOver = false;

    public void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("_Color", hoverColor);
    }

    public void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", baseColor);
    }
}
