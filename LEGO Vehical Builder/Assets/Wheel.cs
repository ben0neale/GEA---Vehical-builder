using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : VehicalPart
{
    

    // Update is called once per frame
    void Update()
    {
        if (placeable && GetSelected())
        {
            ConnectPart(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        placeable = true;
    }

    private void OnMouseDown()
    {
        SetSelected();
    }

    private void OnMouseUp()
    {
        SetNotSelected();
    }

}
