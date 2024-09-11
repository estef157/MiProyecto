using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_1 : MonoBehaviour
{
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

    
    void Update()
    {
        
    }
}
