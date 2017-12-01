using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RevAirTap : MonoBehaviour, IInputClickHandler
{

    //Cube Prefab を扱う変数
    public GameObject ball;
    public GameObject domino;
    public GameObject plane;
    public GameObject stage;
    public GameObject slope;
    public GameObject goal;
    public GameObject adjust;
    public GameObject wide;
    public GameObject sara;
    public GameObject canon;
    public GameObject fan;

    public bool setball;
    public bool setboard;
    public bool setplane;
    public bool setstage;
    public bool setslope;
    public bool setgoal;
    public bool setwide;
    public bool setsara;
    public bool setcanon;
    public bool setfan;

    public bool setdelete;
    public bool set_createmode;
    public bool set_adjustmode;


    public RevAirTap rev;


    //AirTapされたときに呼び出される関数
    public void OnInputClicked(InputClickedEventData eventData)
    {
      
        if (setball == true)
        {
            GameObject cube = GameObject.Instantiate(ball);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }
        else if (setboard == true)
        {
            GameObject cube = GameObject.Instantiate(domino);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }
        else if (setplane == true)
        {
            GameObject cube = GameObject.Instantiate(plane);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }
        else if (setstage == true)
        {
            GameObject cube = GameObject.Instantiate(stage);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }
        else if (setslope == true)
        {
            GameObject cube = GameObject.Instantiate(slope);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }
        else if (setgoal == true)
        {
            GameObject cube = GameObject.Instantiate(goal);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }
        else if (setwide == true)
        {
            GameObject cube = GameObject.Instantiate(wide);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }
        else if (setsara == true)
        {
            GameObject cube = GameObject.Instantiate(sara);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }
        else if (setcanon == true)
        {
            GameObject cube = GameObject.Instantiate(canon);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }
        else if (setfan == true)
        {
            GameObject cube = GameObject.Instantiate(fan);//Cube Prefab の情報を用いて実体
            cube.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);  //自分からみて前方1.2mの位置を空間内の位置に変換
        }


        else if (setdelete == true)
            {
                Destroy(gameObject);
            }

            else
            {
                print("AirTapされました");
            }
        }
       
    

    public void BallClickButton()
    {
        rev.setball = true;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void BoardClickButton()
    {
        rev.setball = false;
        rev.setboard = true;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void PlaneClickButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = true;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void StageClickButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = true;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void SlopeClickButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = true;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void GoalClickButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = true;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void EmptyClickButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void DeleteClickButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = true;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void WideClickButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = true;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void SaraClickButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = true;
        rev.setcanon = false;
        rev.setfan = false;
    }

    public void CanonButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = true;
        rev.setfan = false;
    }

        public void FanButton()
    {
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = true;
    }


    public void CreateModeButton()
    {
        rev.set_createmode = true;
        rev.set_adjustmode = false;
        print("CreateMode");
        // adjust.SetActive(false);
       // Destroy(adjust);
        //Instantiate(rev.adjust);
    }

    public void AdjustModeButton()
    {
        rev.set_createmode = false;
        rev.set_adjustmode = true;
        print("AdjustMode");
        //adjust.SetActive(true);
    }

    
    // Start関数は初期化のために一度だけ実行される
    void Start()
    {
        RevAirTap rev = new RevAirTap();
        rev.setball = false;
        rev.setboard = false;
        rev.setplane = false;
        rev.setstage = false;
        rev.setslope = false;
        rev.setgoal = false;
        rev.setdelete = false;
        rev.setwide = false;
        rev.setsara = false;
        rev.setcanon = false;
        rev.setfan = false;

        rev.set_createmode = false;
        rev.set_adjustmode = false;

        //AirTap の通知が gameObject に渡るように設定
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }
    // Update は毎フレーム毎実行される
    void Update()
    {
   
    }
}