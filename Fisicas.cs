using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisicas : MonoBehaviour {

	// Use this for initialization
	public void Shoot () {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        float x = Random.Range(-1f, 1f);
        rb.AddForce(new Vector3(x,0f,1f) * 100f, ForceMode.Impulse);
    }
	
}
