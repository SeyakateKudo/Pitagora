using UnityEngine;
using System.Collections;

public class Shott : MonoBehaviour
{

    public GameObject bullet;
    //public GameObject body;
    public Transform muzzle;
    public GameObject muzz;
    public float speed = 1000;
    bool shotpower;

    //弾を撃つ間隔をあける
    float interval;

    //弾
    public GameObject enemyBullet;

    // Use this for initialization
    void Start()
    {
        //intervalの初期値の設定
        interval = 0;
    }

    // Update is called once per frame
    void Update()
    {
      
        //弾を撃つメソッドを呼び出す
        interval += Time.deltaTime;
        if (interval >= 100f)
        {
            GenerateEnemyBullet();
        }
    }

    //弾を撃つメソッド
    void GenerateEnemyBullet()
    {
        interval = 0.0f;

        GameObject bullets = GameObject.Instantiate(bullet) as GameObject;
        Vector3 force;
        force = this.gameObject.transform.forward* speed;

        bullets.GetComponent<Rigidbody>().AddForce(force);

        bullet.transform.position = muzzle.position;
                    //Destroy(body,0.05f);
    }

}