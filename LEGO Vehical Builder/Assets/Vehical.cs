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

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
                    transform.position = transform.position + new Vector3(0, 0, 50 * Time.deltaTime);
                }
            }
        }
    }

    public void AddPart(GameObject part)
    {
        Parts.Add(part);
        part.transform.parent = this.transform;
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
