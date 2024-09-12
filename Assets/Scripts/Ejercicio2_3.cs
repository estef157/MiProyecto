using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 3;
    float exp = 1.2f;
    float resultadoUno = 0;
    float resultadoDos = 0;
    float resultadoTres = 0;
    float resultadoCuatro = 0;
    float resultadoCinco = 0;
    void Start()
    {
        resultadoUno = vidas * exp;
        resultadoDos = vidas / exp;
        resultadoTres = vidas % exp;
        resultadoCuatro = vidas * 2;
        resultadoCinco = exp * 3;
        Debug.Log(vidas);
        Debug.Log(exp);
        Debug.Log(resultadoUno);
        Debug.Log(resultadoDos);
        Debug.Log(resultadoTres);
        Debug.Log(resultadoCuatro);
    }

    void Update()
    {
        
    }
}
