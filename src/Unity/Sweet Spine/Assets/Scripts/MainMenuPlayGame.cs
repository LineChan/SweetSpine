﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuPlayGame : MonoBehaviour {
	public string sceneName;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnclickPlayGame() {
		SceneManager.LoadScene (sceneName);
	}

	public void OnclickExitGame() {

		Application.Quit ();
	}
}