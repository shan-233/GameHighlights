using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 場景管理
public class GTN_Game : MonoBehaviour
{
    public InputField playerAnswerUI;
    public int playerAnswer;
    public int correctAnswer;
    public Text hintMessage;
    public GameObject reStart;
    public GameObject txt_count; // 翻牌次數
    public GameObject txt_time; // 遊戲時間


    void Start()
    {
        txt_count = GameObject.Find("Count"); // 設定txt_count找到紀錄翻牌次數的Count
        txt_time = GameObject.Find("Time"); // 設定txt_time找到紀錄時間的Time
        
        global.gtn_total_count = 0;
        global.gtn_time = 0;
        
        NewQuestion();
    }

    void Update()
    {
        txt_count.GetComponent<Text>().text = global.gtn_total_count.ToString(); //更新count顯示到Text上
        txt_time.GetComponent<Text>().text = global.gtn_time.ToString(); //更新時間顯示到Text上
    }


    void UpdateHintMessage(string message) {
        hintMessage.text = message;
    }


    void NewQuestion() {
        UpdateHintMessage("請輸入0到99之間的數字");
        correctAnswer = Random.Range(0, 100); // 0~99
        reStart.gameObject.SetActive(false); // 消失重新輸入的鍵
    }


    // 防呆功能->playerAnswerUI.text可成功跟轉成int丟到playerAnswer
    // playerAnswer變數在外面宣告要加out
    bool CanGetInputNumber() {
        return int.TryParse(playerAnswerUI.text, out playerAnswer);
    }


    public void CompareNumbers() {

        if(global.gtn_total_count == 0){ // 如果次數等於0，就在一秒後呼叫timeCount每一秒執行一次（等於0是因為要只讓這個判斷執行一次）
            InvokeRepeating("timeCount", 1f, 1f);
        }

        if (!CanGetInputNumber()) // 不等於數字
        {
            global.gtn_total_count++;
            UpdateHintMessage("只能輸入數字喔");
            return;
        }

        // playerAnswer = int.Parse(playerAnswerUI.text);
        if (playerAnswer == correctAnswer)
        {
            UpdateHintMessage("恭喜你答對了");
            reStart.gameObject.SetActive(true); // 顯示重新輸入的鍵
        }

        if (playerAnswer > correctAnswer)
        {
            global.gtn_total_count++;
            UpdateHintMessage("答案還要再小一點");
        }

        if (playerAnswer < correctAnswer)
        {
            global.gtn_total_count++;
            UpdateHintMessage("答案還要再大一點");
        }

         if (playerAnswer > 100)
        {
            global.gtn_total_count++;
            UpdateHintMessage("請勿輸入超過大於 100 的數字喔");
        }else if(playerAnswer < 0){
            global.gtn_total_count++;
            UpdateHintMessage("請勿輸入超過小於 0 的數字喔");
        }
        FocusPlayerAnswerUI(); // 自動獲取輸入焦點->不用再次點選框框
    }


    // 遊玩時間的function
    public void timeCount(){ 
        if(playerAnswer == correctAnswer){ // 判斷輸入數字與答案一樣
            CancelInvoke("timeCount"); // 關掉這個呼叫
        }else{
            global.gtn_time += 1; // 遊玩時間加一秒
        }
    }


    public void ClearHintMessage() {
        UpdateHintMessage("");
    }


    // 讀取目前在執行的場景
    public void ReloadScene() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(6); // 場景切換
    }


    // 自動獲取輸入焦點->不用再次點選框框
    void FocusPlayerAnswerUI() {
        playerAnswerUI.ActivateInputField();
    }

}