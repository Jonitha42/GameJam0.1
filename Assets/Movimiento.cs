using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public CharacterController controller;
    private Transform cam;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    void Update()
    {
        float horizontal= Input.GetAxisRaw("Horizontal");
        float vertical= Input.GetAxisRaw("Vertical");
        Vector3 direccion = new Vector3(horizontal,0f,vertical).normalized;
        if (direccion.magnitude >=0.1f)
        {
            float targetAngle = Mathf.Atan2(direccion.x, direccion.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity , turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f,angle, 0f);

            controller.Move(direccion * speed * Time.deltaTime);
        }
    }
}