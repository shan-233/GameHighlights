using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random=UnityEngine.Random;

public class MF_Game : MonoBehaviour
{
    public GameObject[] front = new GameObject[12]; // 全部水果圖
    public GameObject[] back = new GameObject[12]; // 全部的封面圖
    public GameObject[] button = new GameObject[12]; // 按鈕
    public GameObject[] org = new GameObject[6]; // 原本的圖
    public GameObject[] img = new GameObject[6]; // 比對的圖

    void Start()
    {
        int[] a = GetRandomNum(); // 宣告名為a的int陣列，把隨機亂數陣列的結果裝進去

        front[0] = GameObject.Find("front_1"); // 設定fornt[0]找到front_1
        front[1] = GameObject.Find("front_2"); // 設定fornt[1]找到front_2
        front[2] = GameObject.Find("front_3"); // 設定fornt[2]找到front_3
        front[3] = GameObject.Find("front_4"); // 設定fornt[3]找到front_4
        front[4] = GameObject.Find("front_5"); // 設定fornt[4]找到front_5
        front[5] = GameObject.Find("front_6"); // 設定fornt[5]找到front_6
        front[6] = GameObject.Find("front_7"); // 設定fornt[6]找到front_7
        front[7] = GameObject.Find("front_8"); // 設定fornt[7]找到front_8
        front[8] = GameObject.Find("front_9"); // 設定fornt[8]找到front_9
        front[9] = GameObject.Find("front_10"); // 設定fornt[9]找到front_10
        front[10] = GameObject.Find("front_11"); // 設定fornt[10]找到front_11
        front[11] = GameObject.Find("front_12"); // 設定fornt[11]找到front_12

        for (int i = 0; i <= a.Length ; i++) //for迴圈
        {  
           front[i].GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("MemoryFlop/img_"+a[i]);  // 設定front0~11抓到從Random出來的值
        }
    }

    
    void Update()
    {
        if(global.mf_count >= 2){ // 如果亮兩張牌
            for (int i = 0; i < button.Length ; i++)
            {
                button[i].SetActive(false); // 全部按鈕設置為不可見（表示不能再翻）
            }
        }
    }

    public int[] GetRandomNum() //生成亂數的function
    {
        int[] num = {1,2,3,4,5,6,7,8,9,10,11,12}; // 新增一個名為num的int陣列，裡面放1~8的數字
        // 使用for迴圈讓他跑num裡面的長度，產生不重複的隨機亂數
        for (int i = 0; i < num.Length; i++){ 
            int temp = num[i]; 
            int randomIndex = Random.Range(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num; // 當for完成時，回傳num值
    }

    public void touchBack1(){
        if (back[0].activeInHierarchy) // 判斷back1是否為顯示狀態，是的話
        {
            back[0].SetActive(false); // 就設置成不可見
            global.mf_count++; //可翻牌次數+1
        }else //如果不是顯示狀態但還是按牌
        {
            back[0].SetActive(false); //就維持狀態不可見，翻牌次數也不用+1
        }
    }

    public void touchBack2(){
        if (back[1].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[1].SetActive(false);
            global.mf_count++;
        }else
        {
            back[1].SetActive(false);
        }
    }

    public void touchBack3(){
        if (back[2].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[2].SetActive(false);
            global.mf_count++;
        }else
        {
            back[2].SetActive(false);
        }
    }

    public void touchBack4(){
        if (back[3].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[3].SetActive(false);
            global.mf_count++;
        }else
        {
            back[3].SetActive(false);
        }
    }

    public void touchBack5(){
        if (back[4].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[4].SetActive(false);
            global.mf_count++;
        }else
        {
            back[4].SetActive(false);
        }
    }

    public void touchBack6(){
        if (back[5].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[5].SetActive(false);
            global.mf_count++;
        }else
        {
            back[5].SetActive(false);
        }
    }

    public void touchBack7(){
        if (back[6].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[6].SetActive(false);
            global.mf_count++;
        }else
        {
            back[6].SetActive(false);
        }
    }

    public void touchBack8(){
        if (back[7].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[7].SetActive(false);
            global.mf_count++;
        }else
        {
            back[7].SetActive(false);
        }
    }

    public void touchBack9(){
        if (back[8].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[8].SetActive(false);
            global.mf_count++;
        }else
        {
            back[8].SetActive(false);
        }
    }

    public void touchBack10(){
        if (back[9].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[9].SetActive(false);
            global.mf_count++;
        }else
        {
            back[9].SetActive(false);
        }
    }

    public void touchBack11(){
        if (back[10].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[10].SetActive(false);
            global.mf_count++;
        }else
        {
            back[10].SetActive(false);
        }
    }

    public void touchBack12(){
        if (back[11].activeInHierarchy) // 判斷back1是否為顯示狀態
        {
            back[11].SetActive(false);
            global.mf_count++;
        }else
        {
            back[11].SetActive(false);
        }
    }
}
