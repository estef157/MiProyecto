using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_3 : MonoBehaviour
{
    int numeroEjemplo = 14;

    void Start()
    {
        if (numeroEjemplo < 0 || numeroEjemplo > 9) 
        {
            Debug.Log("El número esta entre el 0 y el 9");
        }
        else
        {
            Debug.Log("El número NO esta entre el 0 yeñ 9");
        }
    }

    
    
}
