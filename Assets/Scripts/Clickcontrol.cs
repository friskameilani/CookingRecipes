using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickcontrol : MonoBehaviour
{
	public static string nameofobj;
	public GameObject objnametext;
	public GameObject scoreText;
	public static int theScore;
	
	void Start(){
        
	}

	void Update(){
        
	}

	void OnMouseDown(){
        nameofobj = gameObject.name;
        Debug.Log(nameofobj);
        Destroy(gameObject);
        Destroy(objnametext);
	ScoringSystem.theScore += 50;
	}
}
