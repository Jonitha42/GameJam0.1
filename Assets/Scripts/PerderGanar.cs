﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerderGanar : MonoBehaviour
{
   

   
    void FixedUpdate () {



      if (Input.GetKeyDown(KeyCode.Space))
           SceneManager.LoadScene(0);
    

}
 
 
 }

