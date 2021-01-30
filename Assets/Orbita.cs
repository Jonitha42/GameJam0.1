using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Orbita : MonoBehaviour
{
    public GameObject objeto;
    public float velocidad=3;
    void Update()
    {
        OrbitAround();
    }
    void OrbitAround() 
    {
        transform.RotateAround(objeto.transform.position, Vector3.up, velocidad * Time.deltaTime);
    }
}
