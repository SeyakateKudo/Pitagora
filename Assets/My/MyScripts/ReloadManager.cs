using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {


        // 現在読み込んでいるシーンの名前を取得
        string currentScene = SceneManager.GetActiveScene().name;
        // 取得したシーン名で再読込み
        SceneManager.LoadScene(currentScene);
    }

}
