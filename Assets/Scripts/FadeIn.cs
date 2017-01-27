﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeIn : MonoBehaviour {


	public float fadeInTime;

	private Image fadePanel;
	private Color currentColor = Color.black;


	// Use this for initialization
	void Start () {

		fadePanel = GetComponent<Image> ();
		gameObject.SetActive (true);
		currentColor.a = 1;
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.timeSinceLevelLoad < fadeInTime) {

			// fade in
			float alphaChange = (Time.deltaTime / fadeInTime);

			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;

		} else {

			// deactivate panel
			gameObject.SetActive (false);

		}
	}
}
