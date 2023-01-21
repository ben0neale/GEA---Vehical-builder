using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : VehicalPart
{
    [SerializeField] WheelCollider collider;

    private void Update()   
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            collider.motorTorque = 500f;
            collider.brakeTorque = 0f;
        }
        else
        {
            collider.brakeTorque = 1000f;
        }
    }

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
