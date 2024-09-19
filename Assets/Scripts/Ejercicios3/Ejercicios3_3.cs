using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios3_3 : MonoBehaviour
{
    int primerNumero = 1;
    int primerNumeroDoble = 0;
    int primerNumeroTriple = 0;
    void Start()
    {
        Debug.Log(primerNumero);
        primerNumeroDoble = primerNumero * 2;
        Debug.Log(primerNumeroDoble);
        primerNumeroTriple = primerNumero * 3;
        Debug.Log(primerNumeroTriple);
    }

}
