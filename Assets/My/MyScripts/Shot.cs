using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    public GameObject bullet;
    public GameObject body;
    public Transform muzzle;
    public float speed = 1000;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            GameObject bullets = GameObject.Instantiate(bullet) as GameObject;
            Vector3 force;
            force = this.gameObject.transform.forward * speed;
            bullets.GetComponent<Rigidbody>().AddForce(force);
            bullet.transform.position = muzzle.position;
            Destroy(body,0.05f);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
