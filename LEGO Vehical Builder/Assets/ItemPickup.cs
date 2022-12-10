using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] GameController gamecontroller;
    [SerializeField] Wheel Wheel;
    [SerializeField] GameObject Base;
    [SerializeField] GameObject camera;

    bool colliding = false;

    // Update is called once per frame
    void Update()
    {
        if (gamecontroller.gameState == GameController.GameState.Build)
        {
            transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), Mathf.Round(transform.position.z));
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "base")
        {
            print("BASE COLLIDE");
            colliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "collision")
        {
            colliding = false;
        }
    }

}
