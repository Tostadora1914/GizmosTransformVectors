using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    //Private Attributes
    private float _solRotationSpeed = 30f;
    private float _satelite1RotationSpeed = 90f;
    private float _rotationAngle;
    //Public Attributes
    public Transform solTransform;
    public Transform centerTransform;
    public Transform satelite1Transform;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    //solTransform.LookAt(centerTransform);
    // Update is called once per frame
    void Update()
    {
        solTransform.RotateAround(centerTransform.position, Vector3.forward, _solRotationSpeed * Time.deltaTime);
        _rotationAngle++;

        satelite1Transform.RotateAround(solTransform.position, Vector3.up, _satelite1RotationSpeed * Time.deltaTime);
    }
}
