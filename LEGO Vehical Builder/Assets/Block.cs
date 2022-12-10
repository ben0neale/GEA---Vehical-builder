using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : VehicalPart
{
    //[SerializeField] GameController gameController;
    //[SerializeField] BoxCollider collider;
    [SerializeField] GameObject outerCollision;

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
