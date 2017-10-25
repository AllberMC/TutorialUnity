using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisicas : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float x = Random.Range(-1f, 1f);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(x,0f,1f) * 100f, ForceMode.Impulse);
    }
	
}
