using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void PlayGame(){
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void BackGame(){
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void QuitGame(){
	Debug.Log("EXIT THE GAME");
	Application.Quit();
	}
	
	public void Padang(){
	SceneManager.LoadScene("Padang");
	}
	
	public void Jakarta(){
	SceneManager.LoadScene("Jakarta");
	}
	
	public void Makassar(){
	SceneManager.LoadScene("Makassar");
	}

	public void Papua(){
	SceneManager.LoadScene("Papua");
	}
}
