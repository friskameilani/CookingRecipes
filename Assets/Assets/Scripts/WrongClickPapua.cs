using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WrongClickPapua : MonoBehaviour
{
	public GameObject scoreText;

    void Start(){

	}

	void OnMouseDown(){
		ScoringSystemPapua.theScore -= 100;
	}	

}
