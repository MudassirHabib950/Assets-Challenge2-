using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
   public float speed = 10.0f;
   public float cooldown = 1.0f;
   public GameObject ballPrefab;
   void Start()
   {

   } 
 void Update()
 {
    // On Space Bar key Press send fire
    if(Input.GetKey(KeyCode.Space) && cooldown <= 0)
    {
        Instantiate(ballPrefab,transform.position,ballPrefab.transform.rotation);
        cooldown = 1.0f;
    }
    if(cooldown > 0)
    {
       cooldown -= Time.deltaTime;

    }
 
 }
}
