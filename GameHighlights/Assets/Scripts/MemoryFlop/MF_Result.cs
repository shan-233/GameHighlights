using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MF_Result : MonoBehaviour
{
    public GameObject MF_Name; // 宣告名字變數
    public GameObject MF_Count; // 宣告翻牌次數變數
    public GameObject MF_Time; //宣告翻牌用時變數

    void Start()
    {
        MF_Name = GameObject.Find("MF_Name");
        MF_Count = GameObject.Find("MF_Count");
        MF_Time = GameObject.Find("MF_Time");

        MF_Name.GetComponent<Text>().text = global.mf_name;
    }

    
    void Update()
    {
        
    }
}
