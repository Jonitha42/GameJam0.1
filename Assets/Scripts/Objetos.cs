using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("Player"))
        
        {
           
            BarradeConcentracion.neg = false;
            Destroy(gameObject);
            
        }

    }
}
