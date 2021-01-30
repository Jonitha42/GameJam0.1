using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SeguimientoDeCamara : MonoBehaviour
{
     public Transform target;
    public Vector3 offset;
    public float followSpeed;
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,target.position + offset, followSpeed);
      
    }
}
