using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enablegr : MonoBehaviour {

    Rigidbody rb;
    public AudioClip audioClip1;
    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
        audioSource.Play();

        GameObject[] ball = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject balls in ball)
        {
            rb = balls.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;
        }
    }
}
