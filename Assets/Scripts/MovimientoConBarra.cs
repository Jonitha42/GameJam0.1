using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    
   Quaternion rotation = Quaternion.LookRotation(mLookDirection); 
    transform.rotation = Quaternion.Lerp(transform.rotation,rotation, mSpeed * Time.deltaTime);
       


        }

           }
}



