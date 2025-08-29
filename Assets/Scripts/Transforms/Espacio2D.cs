using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espacio2D : MonoBehaviour
{
    //Public Attributes
    public Transform playerTransform;
    public Transform sphereTransform;
    public float speedX;
    public float speedY;
    public float speedRotation;
    public float speedRotationSphere;
    //Private Attributes
    private float rotationAngle = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerTransform.Translate(Vector3.right * Time.deltaTime * speedX);
        playerTransform.Translate(Vector3.up * Time.deltaTime * speedY);
        playerTransform.Rotate(Vector3.right * speedRotation * Time.deltaTime);
        sphereTransform.RotateAround(playerTransform.position, Vector3.forward, rotationAngle * Time.deltaTime * speedRotationSphere);
        rotationAngle++;
    }
}
