using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tierra : MonoBehaviour
{
    //Attributes
    public float speed = 10f;
    public Transform solTransform;
    public float angleRotation = 0;
    public float drawRaySpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate y Rotate Around
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
        transform.RotateAround(solTransform.position, Vector3.up, angleRotation * Time.deltaTime * speed);

        //DrawRay
        Debug.DrawRay(transform.position, transform.up * drawRaySpeed, Color.green);
        //Debug.DrawRay(transform.position, transform.right * drawRaySpeed, Color.red); //Eje X
    }
}
