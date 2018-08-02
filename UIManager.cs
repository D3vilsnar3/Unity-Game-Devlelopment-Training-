using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
	public GameObject GameOver;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DidClickPlayAgain(){
		print ("PlayAgain");
		SceneManager.LoadScene ("Scene1", LoadSceneMode.Single);
	}
}
