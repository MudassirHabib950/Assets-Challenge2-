using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
   public float xRange = 10.0f;

    // Update is called once per frame
    void Update() 
    {
        // Moving Player Forward With Speed  in Z direction by Pressing W key 
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,15 * Time.deltaTime);
        }
         // Moving Player Forward With Speed  in -Z direction by Pressing S key 
         if(Input.GetKey(KeyCode.S))
         {
        transform.Translate(0,0,-15 * Time.deltaTime );
          }
          }
}
