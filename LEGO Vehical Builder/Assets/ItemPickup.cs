using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] GameController gamecontroller;
    [SerializeField] VehicalPart vehicalPartref;
    [SerializeField] Wheel Wheel;
    [SerializeField] GameObject Base;
    [SerializeField] GameObject camera;
    [SerializeField] private Material selectBlockmat;

    bool colliding = false;

    public float timer = .1f;

    Color color;

    public GameController gameController;

    // Update is called once per frame
    void Update()
    {
        if (!vehicalPartref.placeable)
        {
            selectBlockmat.color = new Color(0, 0, 0, 0.00001f);
        }
        if (vehicalPartref.placeable && vehicalPartref.GetSelected())
        {
            selectBlockmat.color = new Color(0, 100, 0, 0.00001f);
            vehicalPartref.ConnectPart(gameObject);
        }
        if (gameController.gameState == GameController.GameState.Build)
        {
            GetComponent<Collider>().isTrigger = true;
        }
        else if (gameController.gameState == GameController.GameState.play)
        {
            GetComponent<Collider>().isTrigger = false;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            vehicalPartref.SetNotSelected();
        }

        if (vehicalPartref.tempSelected && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (vehicalPartref.tempSelected)
        {
            vehicalPartref.SetSelected();
            vehicalPartref.tempSelected = false;
            timer = .1f;
        }

        if (vehicalPartref.GetSelected() && gameController.gameState == GameController.GameState.Build && !vehicalPartref.placed)
        {
            vehicalPartref.MovePart(gameObject);
        }



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
