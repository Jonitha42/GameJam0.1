using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKey(KeyCode.Space)) 
          {
              GetComponent<Animator> () .SetBool ("Correr",true);

          }

          else 
          {

              GetComponent<Animator> () .SetBool ("Correr",false);
          }
    }
}
