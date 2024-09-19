using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios2_6 : MonoBehaviour
{
    int primeraPuntuacion = 2;
    int segundaPuntuacion = 3;
    int terceraPuntuacion = 4;
    int media = 0;

    void Start()
    {
        Debug.Log(primeraPuntuacion);
        Debug.Log(segundaPuntuacion);
        Debug.Log(terceraPuntuacion);
        media = primeraPuntuacion + segundaPuntuacion + terceraPuntuacion;
        media = media / 3;
        Debug.Log(media);

    }

   
}
