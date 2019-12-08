using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clickcontrol : MonoBehaviour
{
	public static string nameofobj;
	public GameObject objnametext,scoreText,timer,clicked;

    	void Start(){

	}

	void OnMouseDown(){
        Timer timerScript = timer.GetComponent<Timer>();
        ScoringSystem clickedScript = clicked.GetComponent<ScoringSystem>();
        nameofobj = gameObject.name;
		Debug.Log(nameofobj);
		Destroy(gameObject);
		Destroy(objnametext);
		ScoringSystem.theScore += timerScript.currentTime;
        	clickedScript.clicked++;
	}	

}
