using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WrongClick : MonoBehaviour
{
	public GameObject scoreText;

    void Start(){

	}

	void OnMouseDown(){
		ScoringSystem.theScore -= 100;
	}	

}
