using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : VehicalPart
{
    [SerializeField] GameController gameController;
    [SerializeField] MeshCollider collider;

    // Update is called once per frame
    void Update()
    {
        if (placeable && GetSelected())
        {
            ConnectPart(gameObject);
        }
        if (gameController.gameState == GameController.GameState.Build)
        {
            collider.isTrigger = true;
        }
        else if (gameController.gameState == GameController.GameState.play)
        {
            collider.isTrigger = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collision")
        {
            placeable = true;
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
        SetSelected();
    }

    private void OnMouseUp()
    {
        SetNotSelected();
    }

}
