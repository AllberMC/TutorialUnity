using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePhysics : MonoBehaviour {

    public float speed = 30f;
    

    void FixedUpdate () { //Sera la que mueva nuestro cubo

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W))
        {
            
            rb.MovePosition(rb.position + Vector3.forward * speed * Time.deltaTime); //deltaTime para hacer la velocidad mas pequeña
        }
        else if (Input.GetKey(KeyCode.S))
        {

            rb.MovePosition(rb.position + Vector3.back * speed * Time.deltaTime); //deltaTime para hacer la velocidad mas pequeña
        }
        else if (Input.GetKey(KeyCode.A))
        {

            rb.MovePosition(rb.position + Vector3.left * speed * Time.deltaTime); //deltaTime para hacer la velocidad mas pequeña
        }
        else if (Input.GetKey(KeyCode.D))
        {

            rb.MovePosition(rb.position + Vector3.right * speed * Time.deltaTime); //deltaTime para hacer la velocidad mas pequeña
        }
    }
}
