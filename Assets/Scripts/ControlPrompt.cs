using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPrompt : MonoBehaviour
{
    public float displayTime = 3f;


    //void Update() 
    //{
    //
    //}

    private void Start()
    {
        //if(HideUI)
        Invoke("HidePopup", displayTime);

    }

    void HidePopup () 
    { 
        gameObject.SetActive(false);
    }

}
