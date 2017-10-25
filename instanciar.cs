using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciar : MonoBehaviour {

    public GameObject prefabs;
    private int count = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space)) { 
            GameObject cube = Instantiate(prefabs, transform.position, transform.rotation) as GameObject; //intanciame el objeto en esa posicion y en esa rotacion
            cube.name = "foo" + count++;
            Fisicas fisica = cube.GetComponent<Fisicas>();
            fisica.Shoot();
            Destroy(cube, 3f);
        }
    }
}
