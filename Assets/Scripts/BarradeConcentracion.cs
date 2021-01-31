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

          // ACA VA LA CONDICION DE PERDER
          Invoke("Restart",1f);

        }

    



        if (neg==true){
        Concentracion -=10f * Time.deltaTime;
        }

        else{
          Concentracion +=10f * Time.deltaTime;

        }
    }

      void Restart () 
      
      {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
}
