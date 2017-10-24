using System.Collections; //Siempre debe estar importada
using System.Collections.Generic;
using UnityEngine; //Siempre debe estar importada

public class MoveObject : MonoBehaviour { //Nuestra clase publica esta heredando (:) de la clase MonoBehaviour

    public float deltaRotation = 30f; //velocidad con la que rotamos
    public float deltaMove = 10f; //velocidad con la nos movemos.

    
    
    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();
        Movement();
	}

    void Rotate() { //Con esto realizamos la rotación de nuestro objeto
        if (Input.GetKey(KeyCode.Q)) { 
            transform.Rotate(new Vector3(0f, -deltaRotation, 0f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E)) {
            transform.Rotate(new Vector3(0f, deltaRotation, 0f) * Time.deltaTime);
        }
    }

    void Movement() { //Con esto realizamos el movimiento del objeto, hacemos que se traslade
        if(Input.GetKey(KeyCode.W)) {
            transform.Translate( Vector3.forward * deltaMove * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * deltaMove * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * deltaMove * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * deltaMove * Time.deltaTime);
        }

    }
}
