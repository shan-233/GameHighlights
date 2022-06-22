using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 加入場景管理，用來轉場景
using UnityEngine.UI;

public class D_Button : MonoBehaviour
{
    public GameObject InputName; // 宣告文字框
    public GameObject Msg; // 宣告提示訊息
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GoToGame(){
        if(InputName.GetComponent<InputField>().text.Equals("")){ // 如果輸入框是空白的
            Msg.GetComponent<Text>().text = "名字不能為空喔";  // 顯示提示訊息
        }else{
            global.dm_name = InputName.GetComponent<InputField>().text; //把在遊戲首頁輸入的名字傳到global.dm_name
            SceneManager.LoadScene(11); // 轉場景到遊戲畫面
        }
    }

    public void GoToGameMain(){ //再玩一次的按鈕,但會回到首頁,並請重新輸入名字
        SceneManager.LoadScene(10);
    }

    public void GoToMain(){ //回首頁
        SceneManager.LoadScene(0);
    }
}
