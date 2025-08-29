using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(0, 0), new Vector3(0, 3));
        Debug.DrawLine(new Vector3(0, 3), new Vector3(3, 3));
        Debug.DrawLine(new Vector3(3, 3), new Vector3(3, 0));
        Debug.DrawLine(new Vector3(0, 0), new Vector3(3, 0));
        Debug.DrawLine(new Vector3(0, 0, 0), new Vector3(0, 0, 3));
        Debug.DrawLine(new Vector3(0, 0, 3), new Vector3(3, 0, 3));
        Debug.DrawLine(new Vector3(3, 0, 3), new Vector3(3, 0, 0));
        Debug.DrawLine(new Vector3(0, 3, 0), new Vector3(0, 3, 3));
        Debug.DrawLine(new Vector3(0, 3, 3), new Vector3(3, 3, 3));
        Debug.DrawLine(new Vector3(3, 3, 3), new Vector3(3, 3, 0));
        Debug.DrawLine(new Vector3(0, 0, 3), new Vector3(0, 3, 3));
        Debug.DrawLine(new Vector3(3, 0, 3), new Vector3(3, 3, 3));


    }
}
