
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OrbitaProbando : MonoBehaviour
{
    public GameObject objeto;
    public float velocidad=3;


    public CharacterController controller;

    public float velocidadMovimiento;
    float turnSmoothVelocity;
    private Vector3 playerVelocity;

     bool rotando=true;
  
    void Update()
    {
        OrbitAround();

        if ( playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

         if (Input.GetKey(KeyCode.Space))
        {   
            rotando=false;
        }

        else {rotando=true;}
    }
    void OrbitAround() 
    {
        if (rotando)
        {
        transform.RotateAround(objeto.transform.position , Vector3.up ,velocidad * Time.deltaTime );
        }
    }
}



