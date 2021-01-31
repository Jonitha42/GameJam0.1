using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarradeConcentracion : MonoBehaviour
{
    public Slider sliderConcentracion;

    public static float Concentracion;
    float maxConcentracion=100f;

    void Start()
    {
      Concentracion = maxConcentracion;
    }

    void Update()
    {
        sliderConcentracion.value=Concentracion;
        Concentracion-= 10f* Time.deltaTime ;
    }
}
