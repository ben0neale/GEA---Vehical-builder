using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : VehicalPart
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (placeable)
        {
            ConnectPart(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        placeable = true;
    }
}
