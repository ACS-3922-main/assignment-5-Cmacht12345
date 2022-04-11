using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeDevice : MonoBehaviour
{
    private int _increment = 0;
    public Color current;

    public void Operate()
    {
        Color black = new Color(0, 0, 0, 1);
        Color blue = new Color(0, 0, 1, 1);
        Color green = new Color(0, 1, 0, 1);
        Color yellow = new Color(1, 0.92f, 0.016f, 1);
        Color[] pick = new Color[] {black, blue, green, yellow};
        current = pick[_increment];
        GetComponent<Renderer>().material.color = pick[_increment++];
        if(_increment == 4)
        {
            _increment = 0;
        }
    }

    public Color getColor()
    {
        return current;
    }
}
