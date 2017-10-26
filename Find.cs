using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour {

    void Awake() {
        // GameObject camera = GameObject.Find("Main Camera"); //Con esto buscamos el objeto por el nombre
        //GameObject camera = GameObject.FindGameObjectWithTag("MainCamera"); //De esta forma buscamos uno o varios objectos mediante etiquetas
        //GameObject camera = Camera.main.gameObject;
        //Debug.Log(camera.transform.position);

        //vector de objetos
        GameObject[] objetos = GameObject.FindGameObjectsWithTag("objetos");

        foreach(GameObject go in objetos)
        {
            Debug.Log(go.transform.position);
        }
    }
}
