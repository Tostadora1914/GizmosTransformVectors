using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public string _nombre;

    //Methods
    public void Disparar()
    {
        print("Se ha disparado " + _nombre);
    }
}
