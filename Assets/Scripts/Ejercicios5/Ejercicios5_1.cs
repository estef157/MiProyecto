using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_1 : MonoBehaviour
{
    int vidas1 = 2;
    int vidas2 = 3;
    

    void Start()
    {
        if (vidas1 != vidas2)
        {
            Debug.Log("Las vidas no son iguales.");
        }
    }


    void Update()
    {
        
    }
}
