using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyImputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Key Down & Up: Enter
        if (Input.GetKeyDown(KeyCode.Return))
            print("Se ha pulsado Enter.");
        
        if (Input.GetKey(KeyCode.Return))
            print("Se está Enter.");
        
        if (Input.GetKeyUp(KeyCode.Return))
            print("Se ha soltado Enter.");
        
        //Other Keys
        
        if (Input.GetKeyUp(KeyCode.A))
            print("Se ha soltado A.");
        
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            print("Se ha soltado left.");
        
        if (Input.GetKeyUp(KeyCode.F1))
            print("Se ha soltado F1.");
        
        if (Input.GetKeyUp(KeyCode.Space))
            print("Se ha soltado Space.");
        
        if (Input.GetKeyUp(KeyCode.Escape))
            print("Se ha soltado Escape.");
        
        if (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.LeftAlt))
            print("Se ha soltado Left o Right Alt.");
    }
}
