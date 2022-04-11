using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcController : MonoBehaviour
{
    [SerializeField] private Text _npcText;
    // Start is called before the first frame update
    public void setText()
    {
        _npcText.text = "The Code Is: Blue, Blue, Blue, Blue, Blue \n Press c to change the color of the block";
    }
}
