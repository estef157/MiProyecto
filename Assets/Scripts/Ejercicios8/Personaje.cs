using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    string nombre;
    float vida;
    float experiencia;

    void Start()
    {
        float resultadoNivel = CalcularFloat(0, 0);
    }

    float CalcularFloat (float nivel, float experiencia)
    {
        float calcularNivel = nivel;
        nivel = experiencia / 1000;
        return calcularNivel;
    }


}

