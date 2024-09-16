using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultadoCirculo = CalcularCirculo(13, 3.14f);
        Debug.Log(resultadoCirculo);
    }

    float CalcularCirculo(int radio, float PI)
    {
        float areaCirculo = (radio * radio)*PI;
        return areaCirculo;
    }
}
