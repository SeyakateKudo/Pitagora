
using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Sk : StartGame, IInputClickHandler
{

    public GameObject ball;
    public GameObject ss;
    //public bool checkball;

    public bool checkb;
    

    // Use this for initialization
    void Start()
    {
        ss.GetComponent<Renderer>().material.color = Color.yellow;
        checkb = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(ss.GetComponent<Renderer>().material.color == Color.yellow)
        {
            checkb = true;
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (checkb == true)
        {
            Instantiate(ball, ss.transform.position, ss.transform.rotation);
            ss.GetComponent<Renderer>().material.color = Color.blue;
            checkb = false;
        }

    }

}
