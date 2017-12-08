using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    Animator anim;
    public GameObject flag;
    public AudioClip audioClip2;
    private AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        flag.SetActive(false);
        Enablegr en = new Enablegr();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            flag.SetActive(true);
            anim.SetBool("IsGoal", true);

            GameObject audio = GameObject.FindGameObjectWithTag("Audio");
            Destroy(audio);

            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = audioClip2;
            audioSource.Play();

            Instantiate(audio);

        }
    }

}