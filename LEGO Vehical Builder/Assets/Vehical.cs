using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehical : MonoBehaviour
{
    List<GameObject> Parts = new List<GameObject>();

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
        if (CheckPart("Wheel"))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = transform.position + new Vector3(0, 0, 1);
            }
        }
    }

    public void AddPart(GameObject part)
    {
        Parts.Add(part);
        foreach (GameObject item in Parts)
        {
            print(item.name);
        }
    }

    bool CheckPart(string name)
    {
        foreach (GameObject item in Parts)
        {
            if (item.name == name)
            {
                return true;
            }
        }
        return false;
    }
}
