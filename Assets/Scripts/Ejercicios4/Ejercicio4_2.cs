using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    void Start()
    {
        string resultado = ConstruirNombre("Pepe", "Rodr�guez", "Jim�nez", 20);
        Debug.Log(resultado);
    }

    string ConstruirNombre(string nombre, string apellidoUno, string apellidoDos, int edad)
    {
        string texto = "La personas se llama" + " " + nombre + " " + apellidoUno + " " + apellidoDos;
        return texto;
    }

}
