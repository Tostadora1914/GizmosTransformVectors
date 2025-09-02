using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Attributes
    public Transform cubeTransform;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis("Horizontal");
        //Keyboard Keys Axis Debug
        Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Horizontal"), Color.red);
        Debug.DrawRay(cubeTransform.position, Vector3.up * Input.GetAxis("Vertical"), Color.blue);
        //Mouse Axis Debug (NO ME FUNCIONA)
        //Debug.DrawRay(cubeTransform.position, Vector3.up * Input.GetAxis("Mouse X"), Color.red);
        //Debug.DrawRay(cubeTransform.position, Vector3.up * Input.GetAxis("Mouse Y"), Color.blue);
        //print("Horizontal : " + Input.GetAxis("Horizontal"));

        //Button
        if (Input.GetButtonUp("Fire1"))
            print("Fire!!");
        //Mouse Wheel
        print("Mouse Wheel: " + Input.GetAxis("Mouse ScrollWheel"));
        print("Mouse x: " + Input.GetAxis("Mouse X"));
        print("Mouse y: " + Input.GetAxis("Mouse Y"));

        //Movement by mouse
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Mouse X") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.up * Input.GetAxis("Mouse Y") * Time.deltaTime * speed);
        //Movement by keys
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}
