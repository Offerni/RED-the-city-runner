﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	Text score;
	GameSession gameSession;


	// Use this for initialization
	void Start () {
		score = GetComponent<Text>();
		gameSession = FindObjectOfType<GameSession>();
	}
	
	// Update is called once per frame
	void Update () {
		gameSession.AddToScore(1);
		score.text = gameSession.GetScore().ToString();
	}
}
