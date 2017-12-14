using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public GameObject[] bu = new GameObject[15];
    public GameObject[] trs = new GameObject[6];
    public GameObject on;
    public GameObject off;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OffClick()
    {

        foreach (GameObject bus in bu)
        {
            bus.SetActive(false);
            off.SetActive(false);
            on.SetActive(true);
        }
        foreach (GameObject trss in trs)
        {
            trss.SetActive(true);
        }

    }
    public void OnClick()
    {
        foreach (GameObject bus in bu)
        {
            bus.SetActive(true);
            on.SetActive(false);
            off.SetActive(true);
        }
        foreach (GameObject trss in trs)
        {
            trss.SetActive(false);
        }
    }
}
