using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//using UnityEngine.EventSystems;
[System.Serializable]

public class triggerEvent : MonoBehaviour {
	public GameObject music;
	public int variableInt=0;
//	public Collider collider;
//	[SerializeField] private float m_MaxSpeed = 10f;    

//	// Use this for initialization
//	void Start () {
//		collider = GameComponent<BoxCollider2D> ();
//
//	}
	
	// Update is called once per frame
//	void Update () {
//		if (GetComponent<BoxCollider2D>().isTrigger) {
//			variableInt += 10;
//
//			//music.SetActive (true);
//		}
//		
//	}
	void OnTriggerEnter2D(Collider2D other)
	{
		variableInt += 10;
		music.SetActive (true);
	}
}
