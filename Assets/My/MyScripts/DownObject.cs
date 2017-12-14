using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* ActiveであるGameObjectのみを取得するサンプル
* 2014年12月31日 Buravo
*/
public class DownObject : MonoBehaviour
{
    /*===============================================================*/
    /**
    * @brief 最初に一度だけ実行されるメソッド
    */
    void Start()
    {
        
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
            objs.transform.position -= new Vector3(0.5f,0, 0);

        GameObject[] ply = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject plys in ply)
            plys.transform.position -= new Vector3(0.5f,0, 0);
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
}
