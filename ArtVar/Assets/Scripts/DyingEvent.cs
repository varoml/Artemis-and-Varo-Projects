using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DyingEvent : MonoBehaviour {
	public GameObject gameover;
	public GameObject player;
	public Text textHP;
	public float y;
	//Player Health

	public int PlayerHealth = 100;
	public int MaxPlayerHealth = 100;
	// Use this for initialization
	// Update is called once per frame
	void Update () {
		textHP.text = PlayerHealth.ToString();
		y = transform.position.y;
		if (y <= -12f) 
		{
			player.SetActive (false);
			gameover.SetActive (true);
		}
		if (PlayerHealth == 0) {
			player.SetActive (false);
			gameover.SetActive (true);
		}


	}
	void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.gameObject.tag == "Enemy") {
			PlayerHealth = PlayerHealth - 10;
		}
	}
}