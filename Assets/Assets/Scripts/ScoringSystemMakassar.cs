using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystemMakassar: MonoBehaviour
{
	public Text scoreText;
	public GameObject timer;
	public static float theScore = 0f;
   	public int clicked=0;
	
	void Start(){
		
	}
	
	public void Update(){
		scoreText.GetComponent<Text>().text = "SCORE: " + theScore.ToString("0");
		if (clicked == 13){
            		SceneManager.LoadScene("WinGame");
        	}
	}

}
