using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveEspacial : MonoBehaviour
{
    //Private Attributes

    private float _energia;
    private float _velocidad;
    private float _armamento;

    //Public Attributes

    private float energia;
    private float velocidad;
    private float armamento;

    //Public Methods
    public void Acelerar()
    {

    }
    public void Disparar(Arma arma)
    {
        arma.Disparar();
    }
    //Private Methods

}
