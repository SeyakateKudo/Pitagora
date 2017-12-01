using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shot : MonoBehaviour
{
    public GameObject bullet;
    //public GameObject body;
    public Transform muzzle;
    public GameObject muzz;
    public float speed = 1000;
    bool shotpower;

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            shotpower = true;
            ShotController();
            shotpower = false;
        }
    }

    void ShotController()
    {
        if (shotpower == true)
        {

            GameObject bullets = GameObject.Instantiate(bullet) as GameObject;
            Vector3 force;
            force = this.gameObject.transform.forward* speed;

            bullets.GetComponent<Rigidbody>().AddForce(force);

            bullet.transform.position = muzzle.position;
                        //Destroy(body,0.05f);
        }
    }

        // Use this for initialization
        void Start()
        {
            shotpower = false;
        }
        // Update is called once per frame
        void Update()
        {
        }
     }

/*GameObject bullets = GameObject.Instantiate(bullet) as GameObject;
Vector3 force;
force = this.gameObject.transform.forward* speed;

bullets.GetComponent<Rigidbody>().AddForce(force);

bullet.transform.position = muzzle.position;
            //Destroy(body,0.05f);*/