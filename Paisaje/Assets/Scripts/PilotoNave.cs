using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilotoNave : MonoBehaviour


{
    public float speed =-90.0f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime* speed;

        speed -= transform.forward.y * Time.deltaTime * -50.0f;

        if(speed < 5.0f)
        {
            speed= -5.0f;

        }
        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        
         

    }
}
