using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GTN_Button : MonoBehaviour
{
    public GameObject InputName; // 宣告文字框
    public GameObject Msg; // 宣告提示訊息

    void Start()
    {

    }

    void Update()
    {

    }

    public void goToGTN_Game(){ // 點擊開始遊戲的按鈕觸發這個function
        if(InputName.GetComponent<InputField>().text.Equals("")){ // 如果輸入框是空白的
            Msg.GetComponent<Text>().text = "名字不能為空喔";  // 顯示提示訊息
        }else{
            global.gtn_name = InputName.GetComponent<InputField>().text; //把在MF_Main輸入的名字傳到global.mf_name
            SceneManager.LoadScene(5); // 到MF_Game Scenes
        }
    }

    public void goToMain(){ // 點擊回首頁or上一頁的按鈕觸發這個function
        SceneManager.LoadScene(0); // 到Main Scenes
    }

    public void goToGTN_Main(){ // 點擊再玩一次的按鈕觸發這個function
        SceneManager.LoadScene(4); // 到GTN_Main Scenes
    }
}
