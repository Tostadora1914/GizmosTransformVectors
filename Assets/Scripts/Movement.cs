using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Attributes 
    public float movementSpeed = 5f;
    public float rotationSpeed = 5f;
    public float zoomSpeed = 5f;
    public Transform cameraTransform;

    // Update is called once per frame
    void Update()
    {
        //Movement by keys
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        //Camera rotation
        //cameraTransform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed);
        //Player rotation
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed);

        //Zoom camera
        cameraTransform.LookAt(transform.position);
        cameraTransform.Translate(cameraTransform.forward * Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * zoomSpeed);
    }

}
