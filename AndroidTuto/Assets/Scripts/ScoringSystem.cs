using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {

	static int TheScore;
	public GameObject ScoreDisplay;

	void Start () {
		InvokeRepeating ("AddScore", 1f, 0.1f);
	}
	
	void Update () {
				
	}

	void AddScore (){
		TheScore += 5;
		ScoreDisplay.GetComponent<Text> ().text = "Score : " + TheScore;

	}
}
