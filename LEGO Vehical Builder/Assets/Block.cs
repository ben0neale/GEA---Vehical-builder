using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : VehicalPart
{
    //[SerializeField] GameController gameController;
    //[SerializeField] BoxCollider collider;
    [SerializeField] GameObject outerCollision;
    [SerializeField] Rigidbody RB;
    [SerializeField] GameController GameControllerRef;

    private void Update()
    {
        if (placed)
        {
            outerCollision.SetActive(true);
        }

        if (GameControllerRef.gameState == GameController.GameState.Build)
        {
            RB.constraints = RigidbodyConstraints.FreezeAll;
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstical")
        {
            RB.constraints = RigidbodyConstraints.None;
            gameObject.transform.parent = null;
        }
    }
}
