using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {
    Script1 s1; //var global

	// Use this for initialization
	void Awake () {

        s1 = Camera.main.GetComponent<Script1>(); //Vamos a la camara obtenemos un componente tipo Script1 y guardarlo en la variable
        Debug.Log(s1); //Imprimimos para ver si se encontro

        Script1 s2 = gameObject.GetComponentInChildren<Script1>(); //Lo mismo pero para buscar script en objetos hijos
        Debug.Log(s2);

        Script1[] s3 = gameObject.GetComponentsInChildren<Script1>(); //Buscar en todos los hijos y verlos todos
        Debug.Log(s3.Length);
     }

    void Start()
    {
        s1.Test();
    }
	
	
}
