using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour {
	public Text timer;
//	private string timerText;
	public int currentSeconds=0;
	public int currentMinutes=0;

	// Use this for initialization
	void Start () {
		StartCoroutine("AddTime");
		Time.timeScale = 1; //Just making sure that the timeScale is right
	}
	
	// Update is called once per frame
	void Update () {
		
		if (currentMinutes >= 10 && currentSeconds >= 10) {
			timer.text = ("" + currentMinutes + " : " + currentSeconds);
		} //Showing the Score on the Canvas
		if (currentMinutes < 10 && currentSeconds >= 10) {
			timer.text = ("0" + currentMinutes + " : " + currentSeconds);
		}
		if (currentMinutes < 10 && currentSeconds < 10) {
			timer.text = ("0" + currentMinutes + " : 0" + currentSeconds);
		}
		if (currentMinutes >= 10 && currentSeconds < 10) {
			timer.text = ("" + currentMinutes + " : 0" + currentSeconds);
		}
	}
	
	IEnumerator AddTime()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			if (currentSeconds < 60) {
				currentSeconds++;
			}
			if (currentSeconds >= 60) {
				currentSeconds = 0;
				currentMinutes++;
			}
		}

	}
}
