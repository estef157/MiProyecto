using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios2_8 : MonoBehaviour
{
    int puntos = 120;
    int primeraRonda = 0;
    int segundaRonda= 0;
    int terceraRonda = 0;
    int cuartaRonda = 0;
    int quintaRonda = 0;
    
    void Start()
    {
        primeraRonda = puntos % 3;
        Debug.Log(primeraRonda);
        segundaRonda = puntos % 6;
        Debug.Log(segundaRonda);
        terceraRonda= puntos % 9;
        Debug.Log ( terceraRonda);
        cuartaRonda= puntos % 12;
        Debug.Log(cuartaRonda);
        quintaRonda = puntos % 15;  
        Debug.Log(quintaRonda);
    }

}
