using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    //Atributos
    private float _cantidadGasolina = 1000;
    private float _velocidadActual = 0;
    public string modelo;
    public string color;

    //Métodos
    private void Update()
    {
        ControlarGasolina();
        Acelerar(1);
    }
    void Arrancar()
    {

    }
    void Acelerar(float velocidad)
    {
        _velocidadActual += velocidad;
        print("El coche de color" + color + "tiene una velocidad actual: " + _velocidadActual);
        _cantidadGasolina--;
    }

    void Parar()
    {

    }
    void ControlarGasolina()
    {
        if (_cantidadGasolina <= 0)
        {
            Parar();
        }
    }
}
