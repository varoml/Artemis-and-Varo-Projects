﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public void LoadSceneSelect()
	{
		SceneManager.LoadScene (0);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

}
