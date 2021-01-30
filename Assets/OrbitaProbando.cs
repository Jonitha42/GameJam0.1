
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OrbitaProbando : MonoBehaviour
{
    public GameObject objeto;
    public float velocidad=3;


    public CharacterController controller;

    float turnSmoothVelocity;
    private Vector3 playerVelocity;
  
    void Update()
    {
        OrbitAround();

        if ( playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

         if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direccion = objeto.transform.forward;
            controller.Move(direccion * velocidad * Time.deltaTime);
        }
    }
    void OrbitAround() 
    {
        transform.RotateAround(objeto.transform.position , Vector3.up ,velocidad * Time.deltaTime );
    }
}



