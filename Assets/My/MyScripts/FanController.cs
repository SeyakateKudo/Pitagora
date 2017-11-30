using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanController : MonoBehaviour
{

    public GameObject wind;
    public Transform fanmuzzle;
    public float fanspeed = 1500;

    IEnumerator Wind()
    {
        while(true)
        {
            GameObject winds = GameObject.Instantiate(wind) as GameObject;
            Vector3 force;
            force = this.gameObject.transform.forward * fanspeed;
            winds.GetComponent<Rigidbody>().AddForce(force);
            wind.transform.position = fanmuzzle.position;
            Destroy(winds, 2f);
            yield return new WaitForSeconds(1f);
            print(Time.time);
        }
    }

    // Use this for initialization
    void Start()
    {
        StartCoroutine("Wind");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
