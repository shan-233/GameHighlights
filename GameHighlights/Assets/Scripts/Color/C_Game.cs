using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_Game : MonoBehaviour
{
    public GameObject wp; //中間的桿子
    int random; // 用數字紀錄顏色，1紅、2藍、3綠、4黃
    int randomCount; // 紀錄點擊次數

    void Start()
    {
        // 遊戲一開始就隨機一個顏色
        ColorRandomNum(); // 呼叫隨機某一個顏色的function
        Image img = wp.GetComponent<Image>();
        if(random == 1){
            img.color = UnityEngine.Color.red;
        }else if(random == 2){
            img.color = UnityEngine.Color.blue;
        }else if(random == 3){
            img.color = UnityEngine.Color.green;
        }else if(random == 4){
            img.color = UnityEngine.Color.yellow;
        }


    }


    void Update()
    {
        oneClick(); // 呼叫這個function

        // 判斷針轉的方向
        if(randomCount % 2 == 0){ //如果次數是雙數，就順時針轉
            transform.Rotate(0,0,0.2f);
        }else{
            transform.Rotate(0,0,-0.2f);  //次數是單數，就逆時針轉
        }
        

    }


    // 當滑鼠左鍵點擊一下就會執行判斷
    public void oneClick(){
        Image img = wp.GetComponent<Image>();

        if(Input.GetMouseButtonDown(0)){ // 點擊左鍵
            if(random == 1){ // 如果是紅色
                RedColorRandomNum(); //呼叫這個function
                if(random == 2){
                    img.color = UnityEngine.Color.blue;
                    randomCount++;
                }else if(random == 3){
                    img.color = UnityEngine.Color.green;
                    randomCount++;
                }else if(random == 4){
                    img.color = UnityEngine.Color.yellow;
                    randomCount++;
                }
            }else if(random == 2){ // 如果是藍色
                BlueColorRandomNum();
                if(random == 1){
                    img.color = UnityEngine.Color.red;
                    randomCount++;
                }else if(random == 3){
                    img.color = UnityEngine.Color.green;
                    randomCount++;
                }else if(random == 4){
                    img.color = UnityEngine.Color.yellow;
                    randomCount++;
                }
            }else if(random == 3){ // 如果是綠色
                GreenColorRandomNum();
                if(random == 1){
                    img.color = UnityEngine.Color.red;
                    randomCount++;
                }else if(random == 2){
                    img.color = UnityEngine.Color.blue;
                    randomCount++;
                }else if(random == 4){
                    img.color = UnityEngine.Color.yellow;
                    randomCount++;
                }
            }else if(random == 4){ // 如果是黃色
                YellowColorRandomNum();
                if(random == 1){
                    img.color = UnityEngine.Color.red;
                    randomCount++;
                }else if(random == 2){
                    img.color = UnityEngine.Color.blue;
                    randomCount++;
                }else if(random == 3){
                    img.color = UnityEngine.Color.green;
                    randomCount++;
                }
            }
            
        }
    }


    // 生成遊戲開始四個顏色亂數function
    public int[] ColorRandomNum() 
    {
        int[] num = {1,2,3,4};
        for (int i = 0; i < num.Length; i++){  
            int temp = num[i]; 
            int randomIndex = Random.Range(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        random = num[0]; // random紀錄當前顏色
        return num; 
    }

    // 生成除紅色外的顏色亂數
    public int[] RedColorRandomNum() 
    {
        int[] num = {2,3,4};
        for (int i = 0; i < num.Length; i++){  
            int temp = num[i]; 
            int randomIndex = Random.Range(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        random = num[0];
        return num; 
    }

    // 生成除藍色外的顏色亂數
    public int[] BlueColorRandomNum() 
    {
        int[] num = {1,3,4}; 
        for (int i = 0; i < num.Length; i++){  
            int temp = num[i]; 
            int randomIndex = Random.Range(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        random = num[0];
        return num; 
    }


    // 生成除綠色外的顏色亂數
    public int[] GreenColorRandomNum() 
    {
        int[] num = {1,2,4}; 
        for (int i = 0; i < num.Length; i++){  
            int temp = num[i]; 
            int randomIndex = Random.Range(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        random = num[0];
        return num; 
    }


    // 生成除黃色外的顏色亂數
    public int[] YellowColorRandomNum() 
    {
        int[] num = {1,2,3}; 
        for (int i = 0; i < num.Length; i++){  
            int temp = num[i]; 
            int randomIndex = Random.Range(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        random = num[0];
        return num; 
    }
}
