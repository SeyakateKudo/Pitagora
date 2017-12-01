using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class RemoveRo : MonoBehaviour, IInputClickHandler
{
   public GameObject ChildObject;
    public GameObject parentObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        ChildObject.transform.parent = null;
        Destroy(parentObject);
    }


}
