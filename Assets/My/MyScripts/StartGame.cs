using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    Rigidbody rb;
    public AudioClip audioClip1;
    private AudioSource audioSource;
    public GameObject world;
    bool startflag;
    public bool checkball;
    public GameObject sk;
    public Sk scriptSK;
    

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        startflag = true;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void OnClick()
    {
        //PlayAudio();
        //Worldz();
        StartCoroutine(Sample());
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

    /*public void Worldz()
    {
        if (startflag == true)
        {
            GameObject[] obj = GameObject.FindGameObjectsWithTag("Obj");
            foreach (GameObject objs in obj)
                objs.transform.position += new Vector3(0, 0, 1f);

            GameObject[] st = GameObject.FindGameObjectsWithTag("St");
            foreach (GameObject sts in st)
                sts.transform.position += new Vector3(0, 0, 1f);

            GameObject[] ply = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject plys in ply)
                plys.transform.position += new Vector3(0, 0, 1f);
            startflag = false;
        }
    }*/

    private IEnumerator Sample()
    {
        GameObject[] st = GameObject.FindGameObjectsWithTag("St");
        foreach (GameObject sts in st)
            sts.GetComponent<Renderer>().material.color = Color.yellow;

        yield return new WaitForSeconds(1.0f);

        GameObject pl = GameObject.FindGameObjectWithTag("Player");
        GameObject zanzo = pl.transform.Find("Zanzo").gameObject;
        zanzo.SetActive(true);

        GameObject[] ball = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject balls in ball)
        {
            rb = balls.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;
        }

        /*bool値参照失敗
        sk = GameObject.Find("st");
        scriptSK = sk.GetComponent<Sk>();
        checkball = scriptSK.checkb;
        checkball = true;*/
    }
}
