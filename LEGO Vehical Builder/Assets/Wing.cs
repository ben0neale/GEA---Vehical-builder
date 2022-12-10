using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing : VehicalPart
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collision")
        {
            placeable = true;
        }
        if (other.gameObject.tag == "base")
        {
            placeable = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "collision")
        {
            placeable = false;
        }
    }

    private void OnMouseDown()
    {
        tempSelected = true;
    }
}
