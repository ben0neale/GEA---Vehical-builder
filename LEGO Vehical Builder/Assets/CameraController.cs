using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Set Camera rotation speed
    float CamSpeed = 40f;

    // Update is called once per frame
    void Update()
    {
        //Take the x and y inputs from the player
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //Rotate the camera around the vehicle base according player inputs
        transform.RotateAround(Vector3.zero, Vector3.up, x * CamSpeed * Time.deltaTime);
        transform.RotateAround(Vector3.zero, transform.right, y * CamSpeed * Time.deltaTime);
    }
}
