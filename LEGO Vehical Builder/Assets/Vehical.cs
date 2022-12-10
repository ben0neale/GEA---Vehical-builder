using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehical : MonoBehaviour
{
    [SerializeField] GameController gameController;
    List<GameObject> Parts = new List<GameObject>();
    [SerializeField] Rigidbody RB;
    bool changed = false;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (gameController.gameState == GameController.GameState.play)
        {
            if (!changed)
            {
                transform.position = new Vector3(100, 10, 100);
                RB.useGravity = true;
                changed = true;
            }

            if (CheckPart("Wheel"))
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    transform.position = transform.position + transform.forward * 8 * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Rotate(0, 100 * Time.deltaTime, 0);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Rotate(0, -100 * Time.deltaTime, 0);
                }
            }
        }
        if (gameController.gameState == GameController.GameState.Build)
        {
            transform.position = new Vector3(0, 0, 0);
            RB.useGravity = false;
        }
    }

    public void AddPart(GameObject part)
    {
        Parts.Add(part);
        part.transform.parent = transform;
        foreach (GameObject item in Parts)
        {
            print(item.name);
        }
    }

    bool CheckPart(string name)
    {
        foreach (GameObject item in Parts)
        {
            if (item.tag == name)
            {
                return true;
            }
        }
        return false;
    }

}
