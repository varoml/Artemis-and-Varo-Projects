using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
[System.Serializable]

public class urded : MonoBehaviour {
    public GameObject player;
	public GameObject GameOver;
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		player.SetActive (false);
		GameOver.SetActive(true);
	}
}
