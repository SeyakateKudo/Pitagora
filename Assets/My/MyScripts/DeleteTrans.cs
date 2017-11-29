using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeleteTrans : MonoBehaviour, IInputClickHandler
{


    BoxCollider _parent;
    BoxCollider chi;
    private GameObject _trans;


    //AirTapされたときに呼び出される関数
    public void OnInputClicked(InputClickedEventData eventData)
    {
       _parent.enabled = false;
        this.chi.enabled = false;
        Destroy(_trans);
    }


    // Start関数は初期化のために一度だけ実行される
    void Start()
    {
        _trans = transform.parent.gameObject;
        _parent = transform.root.GetComponent<BoxCollider>();
        chi = GetComponent<BoxCollider>();
        _parent.enabled = true;
        this.chi.enabled = true;
        Debug.Log("Parent:" + _parent.name);
        //AirTap の通知が gameObject に渡るように設定
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }
    // Update は毎フレーム毎実行される
    void Update()
    {

    }
}