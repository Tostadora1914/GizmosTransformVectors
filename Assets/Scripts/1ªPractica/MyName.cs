using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // I
        Debug.DrawLine(new Vector2(0, 0), new Vector2(2, 0));
        Debug.DrawLine(new Vector2(1, 0), new Vector2(1, 3));
        Debug.DrawLine(new Vector2(0, 3), new Vector2(2, 3));
        // T: 
        Debug.DrawLine(new Vector2(4, 0), new Vector2(4, 3));
        Debug.DrawLine(new Vector2(4, 3), new Vector2(3, 3));
        Debug.DrawLine(new Vector2(4, 3), new Vector2(5, 3));
        // A:
        Debug.DrawLine(new Vector2(6, 0), new Vector2(6, 3));
        Debug.DrawLine(new Vector2(6, 3), new Vector2(8, 3));
        Debug.DrawLine(new Vector2(8, 3), new Vector2(8, 0));
        Debug.DrawLine(new Vector2(6, 1), new Vector2(8, 1));



    }
}
