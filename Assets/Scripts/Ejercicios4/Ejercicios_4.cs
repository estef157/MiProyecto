using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultadoCirculo = CalcularCirculo(13, 3.14f);
       // float resultadoTriangulo = CalcularTriangulo(2.1f, 3.1f);
        Debug.Log(resultadoCirculo);
        //Debug.Log(resultadoTriangulo);
    }

    float CalcularCirculo(int radio, float PI)
    {
        float areaCirculo = (radio * radio)*PI;
        return areaCirculo;
    }

    //float CalcularTriangulo(float base, float altura)
    //{
    //    float areaTriangulo = (base * altura) / 2;
    //    return areaTriangulo;
    //}



}
