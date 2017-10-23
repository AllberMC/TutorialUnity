using System.Collections; //Siempre debe estar importada
using System.Collections.Generic;
using UnityEngine; //Siempre debe estar importada

public class MoveObject : MonoBehaviour { //Nuestra clase publica esta heredando (:) de la clase MonoBehaviour

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0f, 30f, 0f)*Time.deltaTime);
	}
}
