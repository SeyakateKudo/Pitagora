using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        SizeCon();
    }
    void SizeCon() { 
        if (Input.GetKeyDown(KeyCode.Space))
    
	    gameObject.transform.localScale = new Vector3(
            gameObject.transform.localScale.x - 0.5f,
            gameObject.transform.localScale.y - 0.5f,
            gameObject.transform.localScale.z - 0.5f
	    );
}
}

