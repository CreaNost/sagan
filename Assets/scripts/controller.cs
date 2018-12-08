using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

	public Rigidbody rb;
	public float thrust;

	
	void Start(){
		rb = GetComponent<Rigidbody>();
	}


	void FixedUpdate () {
		if(Input.GetKey("up")){
			rb.AddForce(transform.forward * thrust);
		}

		if(Input.GetKey("down")){
			rb.AddForce((transform.forward * thrust) * -1);
		}
	}
}
