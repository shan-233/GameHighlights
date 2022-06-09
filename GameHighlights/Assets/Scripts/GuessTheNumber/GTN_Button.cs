using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GTN_Button : MonoBehaviour
{
    public GameObject InputName;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void goToGTN_Game(){ // 點擊開始遊戲的按鈕觸發這個function
        global.gtn_name = InputName.GetComponent<InputField>().text; //把在MF_Main輸入的名字傳到global.mf_name
        SceneManager.LoadScene(5); // 到MF_Game Scenes
    }

    public void goToMain(){ // 點擊回首頁or上一頁的按鈕觸發這個function
        SceneManager.LoadScene(0); // 到Main Scenes
    }

    public void goToGTN_Main(){ // 點擊再玩一次的按鈕觸發這個function
        SceneManager.LoadScene(4); // 到GTN_Main Scenes
    }
}
