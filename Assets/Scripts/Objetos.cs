using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    
    private void Ontrigger(Collider other)

    {

        if (other.CompareTag("Player"))
        {
            Debug.Log(other);
            BarradeConcentracion.Concentracion +=50f;
          
        }


    }
}
