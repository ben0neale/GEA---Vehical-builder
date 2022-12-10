using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicalPart : MonoBehaviour
{
    [SerializeField] GameObject SelectedBlock;
    public bool selected = false;
    public bool tempSelected = false;

    [SerializeField] Vehical vehical;
    public bool placeable = false;
    public bool placed = false;

    public float timer = .1f;


    public void ConnectPart(GameObject part)
    {
        if (placeable && Input.GetKeyDown(KeyCode.E))
        {
            placed = true;
            vehical.AddPart(part);
            print("placed");
        }
    }

    public void SetSelected()
    {
        SelectedBlock.SetActive(true);
        selected = true;
    }

    public void SetNotSelected()
    {
        SelectedBlock.SetActive(false);
        selected = false;
    }

    public bool GetSelected()
    {
        return selected;
    }

    public void MovePart(GameObject part)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            part.transform.position = transform.position + new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            part.transform.position = transform.position + new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            part.transform.position = transform.position + new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            part.transform.position = transform.position + new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            part.transform.position = transform.position + new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            part.transform.position = transform.position + new Vector3(0, -1, 0);
        }
    }

}
