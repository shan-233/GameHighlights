using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MF_Game : MonoBehaviour
{
    public GameObject back1;
    public GameObject front1;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void touchBack1(){
        if (back1.activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back1.SetActive(false);
        }else
        {
            back1.SetActive(false);
        }
        
    }
}
