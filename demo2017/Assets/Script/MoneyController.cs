using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float speedMoney = Time.deltaTime * this.speed;
		gameObject.transform.position = new Vector3 ( gameObject.transform.position.x+speedMoney, gameObject.transform.position.y,0);
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("MoneyController >> OnTriggerEnter >> "+other.gameObject.tag);
		if (other.gameObject.gameObject.tag == "ball") {
			SceneBallController.score++;
			Destroy (gameObject);
		} else if (other.gameObject.gameObject.tag == "boundary") {
			Destroy (this.gameObject);
		}
	}


}
