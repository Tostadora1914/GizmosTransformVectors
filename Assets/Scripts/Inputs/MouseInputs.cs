using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    //Public Attributes
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse / Touch
        if (Input.GetMouseButtonUp(0))
            print("Botón Iz");
        if (Input.GetMouseButtonUp(1))
            print("Botón Der");
        if (Input.GetMouseButtonUp(2))
            print("Botón Central");

        //Mouse Position
        print("Mouse x: " + Input.mousePosition.x + "Mouse y: " + Input.mousePosition.y + "Mouse z: " + Input.mousePosition.z);

        target.position = Input.mousePosition;
    }
}
