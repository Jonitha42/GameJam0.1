using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
       
        sliderConcentracion.value= Concentracion;


        if (Concentracion <= 0f || Concentracion >= 100f) 
        {

            SceneManager.LoadScene(3);

        }

    



        if (neg==true){
        Concentracion -=1f * Time.deltaTime;
        }

        else{
          Concentracion +=1f * Time.deltaTime;

        }
    }

      
}
