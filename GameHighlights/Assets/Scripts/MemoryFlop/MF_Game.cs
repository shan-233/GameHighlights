using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random=UnityEngine.Random;
using System.Collections;
using UnityEngine.Events;

public class MF_Game : MonoBehaviour
{
    public GameObject[] front = new GameObject[12]; // 全部水果圖
    public GameObject[] back = new GameObject[12]; // 全部的封面圖
    public GameObject[] button = new GameObject[12]; // 按鈕
    public Sprite[] org = new Sprite[12]; // 原本的圖

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


        for (int i = 0; i <= 11 ; i++) // 進入for迴圈
        {  
           front[i].GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("MemoryFlop/img_"+a[i]);  // 設定front0~11抓到從Random出來的值
        }

        // Debug用
        // front[0].GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("MemoryFlop/img_1");
        // front[1].GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("MemoryFlop/img_7");
        // front[2].GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("MemoryFlop/img_2");
        // front[3].GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("MemoryFlop/img_8");
    }

    
    void Update()
    {
        if(global.mf_count >= 2 && global.mf_flop.Count >= 2){ // 如果亮兩張牌
                  
            for (int i = 0; i < button.Length ; i++)  // 進入for迴圈
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


    public void compare(){

        if(global.mf_flop[0] != null && global.mf_flop[1] != null){

            if(global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_1") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_7") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_2") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_8") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_3") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_9") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_4") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_10") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_5") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_11") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_6") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_12") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_7") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_1") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_8") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_2") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_9") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_3") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_10") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_4") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_11") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_5") ||
                global.mf_flop[0].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_12") && global.mf_flop[1].GetComponent<Image>().sprite == Resources.Load<Sprite>("MemoryFlop/img_6")
                ){

                global.mf_flop_back[0].SetActive(false);
                global.mf_flop_back[1].SetActive(false);
            
                global.mf_count = 0;
                global.mf_flop.Clear();
                global.mf_flop_back.Clear();
            }else{
                // global.mf_flop[0].SetActive(true);
                // global.mf_flop[1].SetActive(true);
                // Invoke("test", 1);
                // CancelInvoke("test");
                global.mf_flop_back[0].SetActive(true);
                global.mf_flop_back[1].SetActive(true);
                global.mf_count = 0;
                global.mf_flop.Clear();
                global.mf_flop_back.Clear();
                
            }
        }
        
    }

    void test(){
        global.mf_flop_back[0].SetActive(true);
        global.mf_flop_back[1].SetActive(true);
        global.mf_count = 0;
        global.mf_flop.Clear();
        global.mf_flop_back.Clear();
    }

    public void touchBack1(){
        if (back[0].activeInHierarchy) // 判斷back1是否為顯示狀態，是的話
        {
            back[0].SetActive(false); // 就設置成不可見
            global.mf_count++; //可翻牌次數+1
            global.mf_flop.Add(front[0]);
            global.mf_flop_back.Add(back[0]);
        }else //如果不是顯示狀態但還是按牌
        {
            back[0].SetActive(false); //就維持狀態不可見，翻牌次數也不用+1
        }
        compare();
    }

    public void touchBack2(){
        if (back[1].activeInHierarchy) 
        {
            back[1].SetActive(false);
            global.mf_count++;
            global.mf_flop.Add(front[1]);
            global.mf_flop_back.Add(back[1]);
        }else
        {
            back[1].SetActive(false);
        }
        compare();
    }

    public void touchBack3(){
        if (back[2].activeInHierarchy) 
        {
            back[2].SetActive(false);
            global.mf_count++;
            global.mf_flop.Add(front[2]);
            global.mf_flop_back.Add(back[2]);
        }else
        {
            back[2].SetActive(false);
        }
        compare();
    }

    public void touchBack4(){
        if (back[3].activeInHierarchy) 
        {
            back[3].SetActive(false);
            global.mf_count++;
            global.mf_flop.Add(front[3]);
            global.mf_flop_back.Add(back[3]);
        }else
        {
            back[3].SetActive(false);
        }
        compare();
    }

    public void touchBack5(){
        if (back[4].activeInHierarchy) 
        {
            back[4].SetActive(false);
            global.mf_count++;
            global.mf_flop.Add(front[4]);
            global.mf_flop_back.Add(back[4]);
        }else
        {
            back[4].SetActive(false);
        }
        compare();
    }

    public void touchBack6(){
        if (back[5].activeInHierarchy) 
        {
            back[5].SetActive(false);
            global.mf_flop.Add(front[5]);
            global.mf_flop_back.Add(back[5]);
            global.mf_count++;
        }else
        {
            back[5].SetActive(false);
        }
        compare();
    }

    public void touchBack7(){
        if (back[6].activeInHierarchy) 
        {
            back[6].SetActive(false);
            global.mf_flop.Add(front[6]);
            global.mf_flop_back.Add(back[6]);
            global.mf_count++;
        }else
        {
            back[6].SetActive(false);
        }
        compare();
    }

    public void touchBack8(){
        if (back[7].activeInHierarchy) 
        {
            back[7].SetActive(false);
            global.mf_flop.Add(front[7]);
            global.mf_flop_back.Add(back[7]);
            global.mf_count++;
        }else
        {
            back[7].SetActive(false);
        }
        compare();
    }

    public void touchBack9(){
        if (back[8].activeInHierarchy) 
        {
            back[8].SetActive(false);
            global.mf_flop.Add(front[8]);
            global.mf_flop_back.Add(back[8]);
            global.mf_count++;
        }else
        {
            back[8].SetActive(false);
        }
        compare();
    }

    public void touchBack10(){
        if (back[9].activeInHierarchy) 
        {
            back[9].SetActive(false);
            global.mf_flop.Add(front[9]);
            global.mf_flop_back.Add(back[9]);
            global.mf_count++;
        }else
        {
            back[9].SetActive(false);
        }
        compare();
    }

    public void touchBack11(){
        if (back[10].activeInHierarchy) 
        {
            back[10].SetActive(false);
            global.mf_flop.Add(front[10]);
            global.mf_flop_back.Add(back[10]);
            global.mf_count++;
        }else
        {
            back[10].SetActive(false);
        }
        compare();
    }

    public void touchBack12(){
        if (back[11].activeInHierarchy) 
        {
            back[11].SetActive(false);
            global.mf_flop.Add(front[11]);
            global.mf_flop_back.Add(back[11]);
            global.mf_count++;
        }else
        {
            back[11].SetActive(false);
        }
        compare();
    }
}