using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarradeConcentracion : MonoBehaviour
{
    public Slider sliderConcentracion;

    public static float Concentracion;
    float maxConcentracion=50;

    public static bool  neg=false;
  float valor;
    void Start()
    {
      Concentracion = maxConcentracion;
    }

    void Update()
    {   
      Debug.Log(neg);
        sliderConcentracion.value= Concentracion;

        if (neg==true){
        Concentracion -=1f * Time.deltaTime;
        }

        else{
          
          Concentracion +=1f * Time.deltaTime;

        }
    }
}
