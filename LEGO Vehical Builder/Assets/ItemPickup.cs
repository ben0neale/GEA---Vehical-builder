using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] GameController gamecontroller;
    [SerializeField] GameObject Base;
    [SerializeField] GameObject camera;

    Vector3 pos;
    bool dragging = false;
    bool colliding = false;
    float zPos = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gamecontroller.gameState == GameController.GameState.Build)
        {
            pos = Input.mousePosition;
            pos.z = zPos;
            pos = Camera.main.ScreenToWorldPoint(pos);
        }

        //transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), Mathf.Round(transform.position.z));

        if (!colliding && zPos < 10)
        {
            zPos += .1f;
        }
    }


    private void OnMouseDrag()
    {
        gameObject.transform.position = pos;
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "base")
        {
            print("BASE COLLIDE");
            colliding = true;
            zPos -= .1f;
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
