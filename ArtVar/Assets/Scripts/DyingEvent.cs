using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyingEvent : MonoBehaviour {
	public GameObject gameover;
	public GameObject player;
	public float y;
	// Use this for initialization
	void Start () {
		
//		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		y = transform.position.y;
		if (y <= -12f) 
		{
			player.SetActive (false);
			gameover.SetActive (true);
		}
		
	}
}
