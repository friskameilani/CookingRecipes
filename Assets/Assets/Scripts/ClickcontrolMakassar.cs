using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickcontrolMakassar : MonoBehaviour
{
	public static string nameofobj;
	public GameObject objnametext,scoreText,timer,clicked;

    	void Start(){

	}

	void OnMouseDown(){
        Timer timerScript = timer.GetComponent<Timer>();
        ScoringSystemMakassar clickedScript = clicked.GetComponent<ScoringSystemMakassar>();
        nameofobj = gameObject.name;
		Debug.Log(nameofobj);
		Destroy(gameObject);
		Destroy(objnametext);
		ScoringSystemMakassar.theScore += timerScript.currentTime;
        	clickedScript.clicked++;
	}	

}
