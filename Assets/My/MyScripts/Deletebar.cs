using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletebar : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        GameObject[] bar = GameObject.FindGameObjectsWithTag("bar"); ;
        foreach (GameObject bars in bar)
        {
            Destroy(bars);
        }
    } 

}

           