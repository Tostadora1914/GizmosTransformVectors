using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionVector : MonoBehaviour
{
    //Public Attributes
    
        //public Vector3 finalPos;
        //public Vector3 initialPos;

    public Transform finalTransform;
    public Transform initialTransform;
    public float speed = 1f;

    //Private Attributes
    private Vector3 _directionVector;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Dibujamos el vector
        Debug.DrawRay(initialTransform.position, _directionVector * speed);
        //Translate
        initialTransform.Translate(_directionVector * Time.deltaTime *  speed);
        //Calculo del vector direcci�n
        _directionVector = finalTransform.position - initialTransform.position;

        //Convierte el vector en unitario
        _directionVector.Normalize();

        //Magnitude
        print("Magnitude : " + _directionVector.magnitude * speed);

        //Distance
        float distance = Vector3.Distance(initialTransform.position, finalTransform.position);
        print("Distance : " + distance);

        if (distance < 10 || distance > 20)
        {
            speed *= -1;
        }
    }
}
