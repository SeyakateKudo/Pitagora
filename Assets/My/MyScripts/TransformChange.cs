using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformChange : MonoBehaviour {

    public GameObject world;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DownClick()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Obj");
        foreach (GameObject objs in obj)
            objs.transform.position -= new Vector3(0, 0.5f, 0);

        GameObject[] ply = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject plys in ply)
            plys.transform.position -= new Vector3(0, 0.5f, 0);
    }

    public void UpperClick()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Obj");
        foreach (GameObject objs in obj)
            objs.transform.position += new Vector3(0, 0.5f, 0);

        GameObject[] ply = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject plys in ply)
            plys.transform.position += new Vector3(0, 0.5f, 0);
    }

    public void LeftClick()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Obj");
        foreach (GameObject objs in obj)
            objs.transform.position -= new Vector3(0.5f, 0, 0);

        GameObject[] ply = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject plys in ply)
            plys.transform.position -= new Vector3(0.5f, 0, 0);
    }

    public void RightClick()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Obj");
        foreach (GameObject objs in obj)
            objs.transform.position += new Vector3(0.5f, 0, 0);

        GameObject[] ply = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject plys in ply)
            plys.transform.position += new Vector3(0.5f, 0, 0);
    }

    public void LeftRote()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Obj");
        foreach (GameObject objs in obj)
            objs.transform.parent = world.transform;

        GameObject[] ply = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject plys in ply)
            plys.transform.parent = world.transform;

        world.transform.Rotate(0, 15, 0);
    }

    public void RightRote()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Obj");
        foreach (GameObject objs in obj)
            objs.transform.parent = world.transform;

        GameObject[] ply = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject plys in ply)
            plys.transform.parent = world.transform;

        world.transform.Rotate(0, -15, 0);
    }
}
