using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManag : MonoBehaviour {
	public GameObject StartButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DidClickPlayAgain(){
		print ("Hello");
		SceneManager.LoadScene ("Scene1", LoadSceneMode.Single);
	}
}
