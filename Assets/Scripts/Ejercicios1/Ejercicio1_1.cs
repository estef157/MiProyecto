using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    string nombre = "Estef";
    void Start()
    {
        Debug.Log("Hola mundo!");
        Debug.Log("Este es el primer videojuego de " + nombre);
        Debug.Log("Estoy aprendiendo C#");
    }

    void Update()
    {
        Debug.Log("Ha pasado un frame");
        //Aparece cada frame debido a que esta en void update y este sucede en cada frame.
    }

}
