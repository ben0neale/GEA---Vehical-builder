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

    public float timer = .1f;


    public void ConnectPart(GameObject part)
    {
        if (placeable && Input.GetKeyDown(KeyCode.E))
        {
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



}
