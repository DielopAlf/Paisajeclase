using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptNave : MonoBehaviour
{
   public Transform NaveEjes;
   public float velocidadMax;
   float velocidad;
   public float velocidadRotacion;
   Rigidbody rb;

   void Start()
   {
       rb = GetComponent<Rigidbody>();
       rb.useGravity=false;
        velocidad=-5f; //para empezar volando
   
   }

    void FixedUpdate()
    {

     rotar();
     acelerar();
    }






   void rotar()
   {
      float yaw = velocidadRotacion * Input.GetAxis("Horizontal")* Time.deltaTime;
      float pitch = velocidadRotacion * Input.GetAxis("Vertical")* Time.deltaTime;
      float roll = velocidadRotacion * Input.GetAxis("Rotate")* Time.deltaTime;

      NaveEjes.Rotate(pitch,yaw,roll);
                                       
        transform.position += (transform.forward * Time.deltaTime * velocidad);


   }
   void acelerar()
   {
      
      if ( velocidad <velocidadMax) 
      {
          
        velocidad += Input.GetAxis("Acelerar")*Time.deltaTime *1.5f;
 

      }

      if(velocidad>velocidadMax*(-1f)) 
      {
          
        velocidad += Input.GetAxis("Acelerar")*Time.deltaTime *1.5f;
 

      }        

      Debug.Log(velocidad);
      
      NaveEjes.position += NaveEjes.forward*velocidad*Time.deltaTime;
   }

                                                                                    


}
