using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D_Result : MonoBehaviour
{
    public GameObject Name; // 宣告名字變數
    public GameObject Correct; // 宣告答對題數
    public GameObject Miss; //宣告錯誤題數變數

    void Start()
    {
        
    }

    void Update()
    {
        Name.GetComponent<Text>().text = global.dm_name;
        Correct.GetComponent<Text>().text = global.dm_total_count.ToString();
        Miss.GetComponent<Text>().text = global.dm_total_miss.ToString();
    }
}
