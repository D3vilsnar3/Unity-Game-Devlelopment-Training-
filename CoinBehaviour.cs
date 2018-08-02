using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour {
	public AudioClip CoinAudio;
	public GameObject CoinEffect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider other)
	{
		print ("Trigger Enter");
		GetComponent<AudioSource>().PlayOneShot(CoinAudio);
		CoinEffect.SetActive(true);
		GetComponentInChildren<MeshCollider>().enabled=false;
		gameObject.GetComponentInChildren<MeshRenderer>().enabled=false;
		Destroy(gameObject,1);
		
	}
}
