using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public float currentTime = 0f;
	float startingTime = 60f;
	public Text timerText;

	void Start(){
        currentTime = startingTime;
	}
	
	void Update(){
		currentTime -= 1 * Time.deltaTime;
		timerText.text = currentTime.ToString("0");
		if(currentTime <= 0){
			SceneManager.LoadScene("LoseGame");
		}
	}
}