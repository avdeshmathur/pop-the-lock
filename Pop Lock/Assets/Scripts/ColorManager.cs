using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color startColor;
    public Color LoseColor;
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.backgroundColor = startColor;
    }

    // Update is called once per frame
    public void changeToLoseColor()
    {
        cam.backgroundColor = LoseColor;
    }

    public void changeToStartColor()
    {
        cam.backgroundColor = startColor;
    }
}
