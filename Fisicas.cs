using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisicas : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //rigidbody.Addforce(Vector3.right + 50f, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
        rigidbody.AddForce(Vector3.one + 50f, ForceMode.Force);
	}
}
