using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
	private static ScoreScript instance;

	void Awake (){
		if(instance != null){
			Destroy (gameObject);
		}
		else{
			instance = this;
			DontDestroyOnLoad(transform.gameObject);
		}
    	}
}