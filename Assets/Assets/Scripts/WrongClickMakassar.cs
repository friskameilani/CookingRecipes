using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WrongClickMakassar : MonoBehaviour
{
	public GameObject scoreText;

    void Start(){

	}

	void OnMouseDown(){
		ScoringSystemMakassar.theScore -= 100;
	}	

}
