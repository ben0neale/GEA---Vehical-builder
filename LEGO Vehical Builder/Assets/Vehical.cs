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
                RB.constraints = RigidbodyConstraints.None;
                RB.useGravity = true;
                changed = true;
            }


            if (CheckPart("Wheel"))
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    foreach (GameObject item in Parts)
                    {
                        if (item.tag == "Wheel")
                        {
                            item.transform.Rotate(0, -1000, 0);
                        }
                    }
                   // transform.position = transform.position + transform.forward * 8 * Time.deltaTime;
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
            if (CheckPart("wing"))
            {
                if (gameController.gameState == GameController.GameState.play)
                {
                    if (Input.GetKeyDown(KeyCode.LeftShift))
                    {
                        RB.AddForce(new Vector3(0, 500000, 0));
                    }
                }
            }
        }
        if (gameController.gameState == GameController.GameState.Build)
        {
            changed = false;
            RB.useGravity = false;
            RB.constraints = RigidbodyConstraints.FreezeAll;
            transform.position = new Vector3(0, 0, 0);
            transform.rotation = Quaternion.identity;
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
