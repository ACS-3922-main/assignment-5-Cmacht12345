using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullScript : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
            GameObject.Find("Canvas").GetComponent<NpcController>().setText();
    }
}
