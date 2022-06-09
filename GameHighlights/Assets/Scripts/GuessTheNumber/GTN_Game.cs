using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//場景管理
public class GTN_Game : MonoBehaviour
{
    public InputField playerAnswerUI;
    public int playerAnswer;
    public int correctAnswer;
    public Text hintMessage;
    public GameObject reStart;
    void Start()
    {
         NewQuestion();
    }

    void UpdateHintMessage(string message) {
        hintMessage.text = message;
    }

    void NewQuestion() {
        UpdateHintMessage("請輸入0到99之間的數字");
        correctAnswer = Random.Range(0, 100);//0~99
        reStart.gameObject.SetActive(false);//消失重新輸入的鍵
    }
    //防呆功能->playerAnswerUI.text可成功跟轉成int丟到playerAnswer
    //playerAnswer變數在外面宣告要加out
    bool CanGetInputNumber() {
        return int.TryParse(playerAnswerUI.text, out playerAnswer);
    }

    public void CompareNumbers() {
        if (!CanGetInputNumber())//不等於數字
        {
            UpdateHintMessage("只能輸入數字喔");
            return;
        }
        //playerAnswer = int.Parse(playerAnswerUI.text);
        if (playerAnswer==correctAnswer)
        {
            UpdateHintMessage("恭喜你答對了");
            reStart.gameObject.SetActive(true);//顯示重新輸入的鍵
        }

        if (playerAnswer > correctAnswer)
        {
            UpdateHintMessage("答案還要再小一點");
        }

        if (playerAnswer < correctAnswer)
        {
            UpdateHintMessage("答案還要再大一點");
        }

        FocusPlayerAnswerUI();//自動獲取輸入焦點->不用再次點選框框
    }

     public void ClearHintMessage() {
        UpdateHintMessage("");
    }
    //目前在執行的場景//讀取目前在執行的場景
    public void ReloadScene() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(4);//場景切換
    }

    void FocusPlayerAnswerUI() {//自動獲取輸入焦點->不用再次點選框框
        playerAnswerUI.ActivateInputField();
    }

    void Update()
    {
        
    }
}
