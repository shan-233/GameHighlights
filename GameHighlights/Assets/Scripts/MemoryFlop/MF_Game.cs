using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MF_Game : MonoBehaviour
{
    public GameObject back1;
    public GameObject back2;
    public GameObject back3;
    public GameObject back4;
    public GameObject front1;

    void Start()
    {

    }

    
    void Update()
    {
        
    }

    public void touchBack1(){
        back1.SetActive(false);
    }

    public void touchBack2(){
        back2.SetActive(false);
    }

    public void touchBack3(){
        back3.SetActive(false);
    }

    public void touchBack4(){
        back4.SetActive(false);
    }
}
