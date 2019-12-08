using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickcontrolPapua : MonoBehaviour
{
	public static string nameofobj;
	public GameObject objnametext,scoreText,timer,clicked;

    	void Start(){

	}

	void OnMouseDown(){
        Timer timerScript = timer.GetComponent<Timer>();
        ScoringSystemPapua clickedScript = clicked.GetComponent<ScoringSystemPapua>();
        nameofobj = gameObject.name;
		Debug.Log(nameofobj);
		Destroy(gameObject);
		Destroy(objnametext);
		ScoringSystemPapua.theScore += timerScript.currentTime;
        	clickedScript.clicked++;
	}	

}
