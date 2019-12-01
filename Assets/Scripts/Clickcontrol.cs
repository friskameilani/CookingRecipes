<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public static string nameofobj;
    public GameObject objnametext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
>>>>>>> c96f318a144556fd176a59065911adc2d0002b90
        nameofobj = gameObject.name;
        Debug.Log(nameofobj);
        Destroy(gameObject);
        Destroy(objnametext);
<<<<<<< HEAD
	ScoringSystem.theScore += 50;
	}
=======
    }
>>>>>>> c96f318a144556fd176a59065911adc2d0002b90
}
