using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicalPart : MonoBehaviour
{
    [SerializeField] GameObject SelectedBlock;
    public bool selected = false;

    [SerializeField] Vehical vehical;
    public bool placeable = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ConnectPart(GameObject part)
    {
        print("PLaceable");
        if (placeable && Input.GetKeyDown(KeyCode.E))
        {
            vehical.AddPart(part);
            print("placed");
        }
    }

    public void SetSelected()
    {
        selected = true;
        SelectedBlock.SetActive(true);
    }

    public void SetNotSelected()
    {
        selected = false;
        SelectedBlock.SetActive(false);
    }

    public bool GetSelected()
    {
        return selected;
    }
}
