using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    Rigidbody rb;
    public AudioClip audioClip1;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        PlayAudio();

        GameObject[] ball = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject balls in ball)
        {
            rb = balls.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;
        }
    }

    public void PlayAudio()
    {
        //audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.enabled = true;
        audioSource.clip = audioClip1;
        audioSource.Play();
    }

    public void StopAudio()
    {
        audioSource.enabled = false;
    }

}
