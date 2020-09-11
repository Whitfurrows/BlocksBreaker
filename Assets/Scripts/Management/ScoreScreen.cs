﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreScreen : MonoBehaviour {

	//[SerializeField] private Text BallsUsedText;
	[SerializeField] private TextMeshProUGUI BallsUsedText;
	[SerializeField] private TextMeshProUGUI DeathsText;
	[SerializeField] private TextMeshProUGUI PowerUpsText;
	[SerializeField] private TextMeshProUGUI BlocksDestroyedText;

	private int ballsUsed;
	private int deaths;
	private int powerUps;
	private int blocksDestroyed;


	void Start () {
		GetData ();
		FillTextFields ();
	}

	void Update(){
		if (Input.GetButtonDown ("Cancel")) {
			FindObjectOfType<LevelManager> ().LoadLevel ("01a Start");
		}
	}

	void GetData(){
		ballsUsed = PlayerPrefsManager.Get_BallsUsed ();
		deaths = PlayerPrefsManager.Get_Deaths ();
		powerUps = PlayerPrefsManager.Get_PowerUps ();
		blocksDestroyed = PlayerPrefsManager.Get_BlocksDestroyed ();
	}

	void FillTextFields(){
		if (SceneManager.GetActiveScene().name.StartsWith ("01c")){
			BallsUsedText.text = ballsUsed.ToString( "d3" );
			DeathsText.text = deaths.ToString( "d3" );
			PowerUpsText.text = powerUps.ToString( "d3" );
			BlocksDestroyedText.text = blocksDestroyed.ToString( "d3" );
		}
	}

}