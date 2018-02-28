using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarColor : MonoBehaviour {

    public GameObject bar;
    private bool flag = false;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        ColorChange();
	}

    private void OnTriggerEnter(Collider other)
    {
        flag = true;
    }

    private void OnTriggerExit(Collider other)
    {
        flag = false;
    }

    private void ColorChange()
    {
        if (flag == true)
        {
            bar.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            bar.GetComponent<Renderer>().material.color = Color.gray;
        }


    }
}

