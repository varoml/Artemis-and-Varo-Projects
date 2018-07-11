using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endEvent : MonoBehaviour {
	public GameObject end; 
	void OnTriggerEnter2D(Collider2D other)
	{
		
		end.SetActive (true);
	}

}
