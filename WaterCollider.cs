using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollider : MonoBehaviour {
	public GameObject PlayAgainMove;
	UIManager _UIManager;

	// Use this for initialization
	void Start () {
		_UIManager = GameObject.Find ("Canvas").GetComponent<UIManager>(); 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/*void OnTriggerEnter(Collider other)
	 {
		print ("Trigger Enter");
		PlayAgainMove.SetActive(true);

	}*/
	void OnCollisionEnter(Collision other){
		print ("Player fell on Water");
		_UIManager.GameOver.SetActive(true);
	}
}
