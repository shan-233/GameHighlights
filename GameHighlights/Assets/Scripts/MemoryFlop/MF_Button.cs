using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MF_Button : MonoBehaviour
{
    public GameObject InputName;
    public GameObject Msg;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void goToMF_Game(){ // 點擊開始遊戲的按鈕觸發這個function
        if(InputName.GetComponent<InputField>().text.Equals("")){ // 如果名字是空白的
            Msg.GetComponent<Text>().text = "名字不能為空喔"; // 顯示提示訊息
        }else{
            global.mf_name = InputName.GetComponent<InputField>().text; //把在MF_Main輸入的名字傳到global.mf_name
            SceneManager.LoadScene(2); // 到MF_Game Scenes
        }
    }

    public void goToMF_Result(){ // 點擊遊戲結果的按鈕觸發這個function
        SceneManager.LoadScene(3); // 到MF_Result Scenes
    }

    public void goToMain(){ // 點擊回首頁的按鈕觸發這個function
        SceneManager.LoadScene(0); // 到Main Scenes
    }

    public void goToMF_Main(){ // 點擊上一頁的按鈕觸發這個function
        SceneManager.LoadScene(0); // 到Main Scenes
    }

    public void playGame_Main(){ // 點擊再玩一次的按鈕觸發這個function
        SceneManager.LoadScene(1); // 到MF_Main Scenes
    }

}
