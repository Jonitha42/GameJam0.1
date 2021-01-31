using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoConBarra : MonoBehaviour
{
    public float velocidadMovimiento;


//                      -----------------------
  public Transform mTarget;

float mSpeed = 5f;

Vector3 mLookDirection;

const float EPSILON = 0.1f;

public float rotationOffset;



    void Update()
    {

         if (Input.GetKey(KeyCode.Space))
       {   
    mLookDirection = (mTarget.position - transform.position).normalized;
    if((transform.position - mTarget.position).magnitude>EPSILON)
    transform.Translate(mLookDirection * Time.deltaTime * mSpeed);
    
        }

     }



     
       private void OnTriggerEnter(Collider other) {

           if (other.CompareTag("Ganar")) {

          Invoke("Restart",1f);

           }
            
       }
     
     void Restart() 
    
     {
       SceneManager.LoadScene(2);
     }



}



