using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1DoorTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] _targets;
    [SerializeField] private GameObject _monitor1;
    [SerializeField] private GameObject _monitor2;
    [SerializeField] private GameObject _monitor3;
    [SerializeField] private GameObject _monitor4;
    [SerializeField] private GameObject _monitor5;
    [SerializeField] private Text island;
    private Color _check1 = new Color(0, 0, 1, 1);
    private Color _check2 = new Color(0, 0, 1, 1);
    private Color _check3 = new Color(0, 0, 1, 1);
    private Color _check4 = new Color(0, 0, 1, 1);
    private Color _check5 = new Color(0, 0, 1, 1);

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (_check1 == _monitor1.GetComponent<ColorChangeDevice>().getColor() &&
            _check2 == _monitor2.GetComponent<ColorChangeDevice>().getColor() &&
            _check3 == _monitor3.GetComponent<ColorChangeDevice>().getColor() &&
            _check4 == _monitor4.GetComponent<ColorChangeDevice>().getColor() &&
            _check5 == _monitor5.GetComponent<ColorChangeDevice>().getColor())
        {
            foreach (GameObject target in _targets)
            {
                target.SendMessage("Activate");
            }
            island.text = "Make your way too the second island to complete the parkour, unlock the door, and eat the Donut";
        }
            

    }
}
