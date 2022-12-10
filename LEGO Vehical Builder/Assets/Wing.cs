using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing : VehicalPart
{
    [SerializeField] GameController gameController;
    [SerializeField] BoxCollider collider;

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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SetNotSelected();
        }

        if (tempSelected && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (tempSelected)
        {
            SetSelected();
            tempSelected = false;
            timer = .1f;
        }

        if (GetSelected() && gameController.gameState == GameController.GameState.Build && !placed)
        {
            MovePart(gameObject);
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
