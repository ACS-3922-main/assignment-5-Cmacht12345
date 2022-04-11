using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Door : MonoBehaviour
{
    [SerializeField] private GameObject[] _targets;
    [SerializeField] private GameObject _monitor1;
    private Color _check1 = new Color(0, 1, 0, 1);
    // Update is called once per frame
    void Update()
    {
        if(_check1 == _monitor1.GetComponent<Switch>().getColor())
        {
            foreach (GameObject target in _targets)
            {
                target.SendMessage("Activate");
            }
        }
    }
}
