using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarColorKoiru : MonoBehaviour {

    public GameObject bar;
    public GameObject bar1;

    bool flag = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ColorChange();
    }

    void OnTriggerStay(Collider other)
    {
        flag = true;
    }

    private void OnTriggerExit(Collider other)
    {
        flag = false;
    }

    void ColorChange()
    {
        if (flag == true)
        {
            bar.GetComponent<Renderer>().material.color = Color.green;
            bar1.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            bar.GetComponent<Renderer>().material.color = Color.gray;
            bar1.GetComponent<Renderer>().material.color = Color.gray;
        }


    }
}
