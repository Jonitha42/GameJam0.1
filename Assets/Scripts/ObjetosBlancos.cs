﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosBlancos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("Player"))
        
        {
           
            BarradeConcentracion.neg = true;
            Destroy(gameObject);
            
        }

    }
}
