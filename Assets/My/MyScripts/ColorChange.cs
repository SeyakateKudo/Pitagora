using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public GameObject sto;

    // Use this for initialization
    void Start()
    {

        //gameObject取得 
        sto = GameObject.Find("st");
        sto.GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
