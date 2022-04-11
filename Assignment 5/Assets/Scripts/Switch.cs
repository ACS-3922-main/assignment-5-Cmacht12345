using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Color current;

    public void Operate()
    { 
        Color green = new Color(0, 1, 0, 1);
        GetComponent<Renderer>().material.color = green;
        current = green;
    }

    public Color getColor()
    {
        return current;
    }
}
