
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
        nameofobj = gameObject.name;
        Debug.Log(nameofobj);
        Destroy(gameObject);
        Destroy(objnametext);
    }
}
