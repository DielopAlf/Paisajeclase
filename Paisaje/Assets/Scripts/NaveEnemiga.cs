using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveEnemiga : MonoBehaviour
{

    float speed = 5.0f;

    public Transform target;

    void Start()
    {
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));  
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed*Time.deltaTime)); 
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.tag =="WayPoint")
        {
            target=other.gameObject.GetComponent<WayPoint>().siguientePunto;
            transform.LookAt(new Vector3(target.position.x,transform.position.y,target.position.z));
        }
    }

}
