using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTN_Result : MonoBehaviour
{
    public GameObject GTN_Name; // 宣告名字變數
    public GameObject GTN_Count; // 宣告次數變數
    public GameObject GTN_Time; //宣告用時變數


    void Start()
    {
        GTN_Name = GameObject.Find("Name");
        GTN_Count = GameObject.Find("Count");
        GTN_Time = GameObject.Find("Time");

        GTN_Name.GetComponent<Text>().text = global.gtn_name;
    }

    void Update()
    {
        
    }
}
