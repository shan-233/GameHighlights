using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTN_Result : MonoBehaviour
{
    public GameObject GTN_Name; // 宣告名字變數
    public GameObject GTN_Count; // 宣告次數變數
    public GameObject GTN_Time; //宣告用時變數
    public GameObject GTN_Level; //宣告等級變數


    void Start()
    {
        GTN_Name = GameObject.Find("Name");
        GTN_Count = GameObject.Find("Count");
        GTN_Time = GameObject.Find("Time");
        GTN_Level = GameObject.Find("Level");

        GTN_Name.GetComponent<Text>().text = global.gtn_name;
        GTN_Count.GetComponent<Text>().text = global.gtn_total_count.ToString();
        GTN_Time.GetComponent<Text>().text = global.gtn_time.ToString();

        if(global.gtn_time <= 10){
            GTN_Level.GetComponent<Text>().text = "A";
        }else if(global.gtn_time > 10 && global.gtn_time <= 15){
            GTN_Level.GetComponent<Text>().text = "B";
        }else{
            GTN_Level.GetComponent<Text>().text = "C";
        }
    }

    void Update()
    {
        
    }
}
