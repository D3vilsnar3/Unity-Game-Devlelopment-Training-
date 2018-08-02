using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float Speed = 25f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			//transform.Translate (Vector3.forward * Speed, Space.World);
			//transform.Rotate (Vector3.right * 10.0f, Space.World);
			GetComponent<Rigidbody>().AddTorque(Vector3.right* Speed);
		}
		
		if (Input.GetKey (KeyCode.S)) {
			//transform.Translate (Vector3.back * Speed, Space.World);
			//transform.Rotate (Vector3.left * 10.0f, Space.World);
			GetComponent<Rigidbody>().AddTorque(Vector3.left* Speed);
		}

		if (Input.GetKey (KeyCode.A)) {
		//	transform.Rotate (Vector3.forward * 10.0f, Space.World);
		//	transform.Translate (Vector3.left * Speed, Space.World);
			GetComponent<Rigidbody>().AddTorque(Vector3.forward* Speed);
		}
		if (Input.GetKey (KeyCode.D)) {
			//transform.Rotate (Vector3.back * 10.0f, Space.World);
			//transform.Translate (Vector3.right * Speed, Space.World);
			GetComponent<Rigidbody>().AddTorque(Vector3.back* Speed);
		}
		if (Input.GetKey (KeyCode.Space)) {
			//transform.Rotate (Vector3.right * 10.0f, Space.World);
			transform.Translate (Vector3.up * 0.5f, Space.World);
		}
		//GetComponent<Transform> ().position = GetComponent<Transform> ().position + Vector3.forward * Speed ;
	}
}
