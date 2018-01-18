using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    Rigidbody rb;
    public AudioClip audioClip1;
    private AudioSource audioSource;
    public GameObject world;

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
        Worldz();
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

    public void Worldz()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Obj");
        foreach (GameObject objs in obj)
            objs.transform.position += new Vector3(0, 0, 1f);

        GameObject[] ply = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject plys in ply)
            plys.transform.position += new Vector3(0, 0, 1f);
    }

    private IEnumerator Sample()
    {
        yield return new WaitForSeconds(1.0f);

        //GameObject zanzo = GameObject.FindGameObjectWithTag("Zanzo");
        //zanzo.SetActive(true);

        GameObject[] ball = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject balls in ball)
        {
            rb = balls.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;
        }
    }
}
