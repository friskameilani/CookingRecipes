using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScore : MonoBehaviour
{
    public GameObject deleteScore;
	public void Start(){
		deleteScore = GameObject.FindGameObjectWithTag("Player");
		Destroy(deleteScore);
	}
	
}
