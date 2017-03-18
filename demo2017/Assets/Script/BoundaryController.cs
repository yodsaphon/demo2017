using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		//Debug.Log ("OnCollisionEnter >> "+collision.gameObject.tag);
		Destroy (collision.gameObject);
	}

//	void OnTriggerEnter(Collider other) {
//		Debug.Log ("BoundaryController >> OnTriggerEnter >> "+other.gameObject.tag);
//		Destroy (other.gameObject);
//	}
}
