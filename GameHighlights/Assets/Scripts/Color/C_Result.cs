using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_Result : MonoBehaviour
{

    public GameObject C_Name; // 宣告名字變數
    public GameObject C_Count; // 宣告翻牌次數變數
    public GameObject C_Time; //宣告翻牌用時變數
    public GameObject C_Level; //宣告等級變數

    void Start()
    {
        C_Name.GetComponent<Text>().text = global.c_name;
        C_Count.GetComponent<Text>().text = global.c_total_count.ToString();
        C_Time.GetComponent<Text>().text = global.c_time.ToString();
        C_Level.GetComponent<Text>().text = global.c_level;
    }


    void Update()
    {
        
    }
}
