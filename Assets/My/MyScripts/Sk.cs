
using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Sk : MonoBehaviour, IInputClickHandler
{

    public GameObject ball;
    public GameObject ss;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Instantiate(ball, ss.transform.position, ss.transform.rotation);
    }


}
