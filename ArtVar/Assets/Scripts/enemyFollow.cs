using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour {
	public float speed;
	private Transform target;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.position.x, transform.position.y, transform.position.z) , speed * Time.deltaTime);
	}
}
