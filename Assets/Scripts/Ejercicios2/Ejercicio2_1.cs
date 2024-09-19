using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_1 : MonoBehaviour
{
    //2_1
    int edad = 0;
    float altura = 1.56f;
    string nombre = "Oli";
    float iva = 4.3f;
    float peso = 50.4f;
    bool alumnoRepetidor = false;
    char letra = 'a';
    int minutos = 3;
    string matriculaCoche = "1234265";
    bool mayorDeEdad = false;
    string codigoPostal = "28005";
    bool genero = false;
    int numeroDeHijos = 5;
    int tallaCamisa = 35;
    float precio = 3.99f;
    string mensaje = "Hola";
    int mayorEdad = 18;
    int dias = 7;
    int contador = 50;
    string tallaCamiseta = "XL";


    //2_2
    int vidas = 5;
    float exp = 2.1f;
    char carac = 'a';
    float resultadoSuma = 0.0f;
    float resultadoResta = 0.0f;
    void Start()
    {
        vidas = 5;
        exp = 2.1f;
        resultadoSuma = (vidas + exp);
        resultadoResta = (vidas - exp);
        Debug.Log (resultadoSuma);
        Debug.Log (resultadoResta);
        

    }

    
   
}
