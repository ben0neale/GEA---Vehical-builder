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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SetNotSelected();
        }

        if (tempSelected && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if(tempSelected)
        {
            SetSelected();
            tempSelected = false;
            timer = .1f;
        }

        if (GetSelected() && gameController.gameState == GameController.GameState.Build)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position = transform.position + new Vector3(1, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position = transform.position + new Vector3(-1, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position = transform.position + new Vector3(0, 0, 1);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position = transform.position + new Vector3(0, 0, -1);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                transform.position = transform.position + new Vector3(0, 1, 0);
            }
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                transform.position = transform.position + new Vector3(0, -1, 0);
            }
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
        tempSelected = true;
    }

    private void OnMouseUp()
    {
        //SetNotSelected();
    }

}
