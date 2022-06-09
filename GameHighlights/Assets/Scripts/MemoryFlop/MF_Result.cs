using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MF_Result : MonoBehaviour
{
    public GameObject MF_Name; // 宣告名字變數
    public GameObject MF_Count; // 宣告翻牌次數變數
    public GameObject MF_Time; //宣告翻牌用時變數
    public GameObject MF_Level; //宣告等級變數

    void Start()
    {
        MF_Name = GameObject.Find("MF_Name");
        MF_Count = GameObject.Find("MF_Count");
        MF_Time = GameObject.Find("MF_Time");
        MF_Level = GameObject.Find("MF_Level");

        MF_Name.GetComponent<Text>().text = global.mf_name;
        MF_Count.GetComponent<Text>().text = global.mf_total_count.ToString();
        MF_Time.GetComponent<Text>().text = global.mf_time.ToString();

        if(global.mf_total_count <= 12){
            MF_Level.GetComponent<Text>().text = "WOW～你是天才吧！";
        }else if(global.mf_total_count > 12 && global.mf_total_count <= 18){
            MF_Level.GetComponent<Text>().text = "厲害喔！";
        }else{
            MF_Level.GetComponent<Text>().text = "加油～";
        }
    }

    
    void Update()
    {
        
    }
}
