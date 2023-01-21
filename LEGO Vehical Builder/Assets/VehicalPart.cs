using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicalPart : MonoBehaviour
{
    //Reference to outer select block
    [SerializeField] GameObject SelectedBlock;
    //Refence to vehicle base
    [SerializeField] Vehical vehical;
    
    public bool selected = false;
    public bool placeable = false;
    public bool placed = false;

    public bool tempSelected = false;

    //Connect the vehicle part to the vehicle base
    public void ConnectPart(GameObject part)
    {
        //if colliding with vehicle base and E pressed
        if (placeable && Input.GetKeyDown(KeyCode.E))
        {
            //set placed
            placed = true;
            //make the select block not visible
            SetNotSelected();
            //add the vehicle part
            vehical.AddPart(part);
        }
    }

    public void SetSelected()
    {
        //Show the select block
        SelectedBlock.SetActive(true);
        selected = true;
    }

    public void SetNotSelected()
    {
        //Dont show the select block
        SelectedBlock.SetActive(false);
        selected = false;
    }

    public bool GetSelected()
    {
        return selected;
    }

    public void MovePart(GameObject part)
    {
        //Move the part with the arrow keys and shift and ctrl
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
