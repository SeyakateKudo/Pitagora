using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("MoveSphere");
    }

    void Update()
    {
       // transform.Rotate(new Vector3(0, 0, 5));
    }

    IEnumerator MoveSphere()
    {
        for (int f = 360; f >= 0; f--)
        {
            yield return new WaitForSeconds(1f);
            gameObject.transform.Rotate(0, f, 0);
        }
    }

}