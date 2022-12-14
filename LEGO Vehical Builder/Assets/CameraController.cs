using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float CamSpeed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.RotateAround(Vector3.zero, Vector3.up, x * CamSpeed * Time.deltaTime);
        transform.RotateAround(Vector3.zero, transform.right, y * CamSpeed * Time.deltaTime);
    }
}
