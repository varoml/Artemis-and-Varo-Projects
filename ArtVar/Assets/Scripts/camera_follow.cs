﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {

	public Transform player;
	void FixedUpdate ()
	(
	 transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
	)
}
