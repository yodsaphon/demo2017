﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "ball") {
			Destroy (collision.gameObject);
		} 
	}
}
