using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour {
	public GameObject Player;
	public float Height;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Player.transform.position.x, Height , Player.transform.position.z);
	}
}
