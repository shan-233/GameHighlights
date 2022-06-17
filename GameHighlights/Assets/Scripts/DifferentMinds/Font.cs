using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //引用UI套件
using Excel;
using System.Data;
using System.IO;
using OfficeOpenXml;

public class Font : MonoBehaviour
{
    public GameObject word; // 字和顏色
    public GameObject button1; // 左邊按鈕
    public GameObject button2; // 右邊按鈕
    public GameObject startButton; // 開始遊戲按鈕

    GameObject resultImg; // 遊戲結束時會顯示白色刷淡背景    
    GameObject TimeTxt; // 宣告倒數計時
    GameObject resultTxt; //宣告遊戲結束
    GameObject missTxt; // 宣告點擊錯誤次數
    GameObject msgTxt; // 宣告提示訊息
    GameObject button1_Text; // 左邊按鈕的文字
    GameObject button2_Text; // 右邊按鈕的文字

    Color redColor; //宣告紅色
    Color orangeColor; //橙
    Color yellowColor; //黃
    Color greenColor;  //綠
    Color blueColor;   //藍
    Color indigoColor; //靛
    Color purpleColor; //紫

    static int time = 15; // 宣告倒數計時時間
    static string randomColorText; // 宣告按鈕上的文字
    static int topic = 0; // 紀錄7個題目
    static string[] randomWord; // 隨機文字的全域變數
    static Color[] randomColor; //隨機顏色的全域變數
    

    void AllColor(){
        //將顏色轉換成16進制，定義七種顏色
        ColorUtility.TryParseHtmlString("#ff0000", out redColor);
        ColorUtility.TryParseHtmlString("#ff8800", out orangeColor);
        ColorUtility.TryParseHtmlString("#fff700", out yellowColor);
        ColorUtility.TryParseHtmlString("#14ff00", out greenColor);
        ColorUtility.TryParseHtmlString("#005cff", out blueColor);
        ColorUtility.TryParseHtmlString("#2700bd", out indigoColor);
        ColorUtility.TryParseHtmlString("#5900ff", out purpleColor);
    }


    // 把宣告的7種顏色名稱放進color陣列裡面打亂順序
    public Color[] GetRandomColor() 
    {
        Color[] color = {redColor,orangeColor,yellowColor,greenColor,blueColor,indigoColor,purpleColor}; 
        for (int i = 0; i < color.Length; i++){
            Color temp = color[i]; 
            int randomIndex = Random.Range(0, color.Length);
            color[i] = color[randomIndex];
            color[randomIndex] = temp;
        }
        return color; 
    }


    // 宣告7個文字放進word陣列裡面隨機打亂順序
    public string[] GetRandomWord() 
    {
        string[] word = {"紅","橙","黃","綠","藍","靛","紫"}; 
        for (int i = 0; i < word.Length; i++){
            string temp = word[i]; 
            int randomIndex = Random.Range(0, word.Length);
            word[i] = word[randomIndex];
            word[randomIndex] = temp;
        }
        return word; 
    }


    // 宣告2個數字跑隨機順序（用來隨機文字要放在按鈕的左還是右）
    public int[] GetRandomNumButton() 
    {
        int[] num = {1,2}; 
        for (int i = 0; i < num.Length; i++){  
            int temp = num[i]; 
            int randomIndex = Random.Range(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num;
    }


    void Start()
    {
        topic = 0; // 初始化題目數量為0
        time = 15; // 初始化時間為15秒
        global.dm_total_count = 0; // 初始化答對題數為0
        global.dm_total_miss = 0; // 初始化答錯題數為0
        
        word = GameObject.Find("Word"); // 找到Unity裡面的Word文字框
        button1_Text = GameObject.Find("Button_1_Text");
        button2_Text = GameObject.Find("Button_2_Text");
        missTxt = GameObject.Find("Miss");
        msgTxt = GameObject.Find("Msg");
        TimeTxt = GameObject.Find("Time");
        startButton = GameObject.Find("Start");
        resultTxt = GameObject.Find("Result");
        resultImg = GameObject.Find("Result_img");

        AllColor(); // 呼叫AllColor這個功能
        
        randomWord = GetRandomWord();
        randomColor = GetRandomColor(); // 宣告一個叫randomColor的Color陣列，把GetRandomColor隨機出來的結果裝進去

        updateButtonAndWord();
    }

    void Update()
    {
        missTxt.GetComponent<Text>().text = global.dm_total_miss.ToString();
        TimeTxt.GetComponent<Text>().text = time.ToString();
    }

    // 按下開始遊戲，就開始倒數計時
    public void startGame(){
        startButton.SetActive(false); // 設定開始遊戲按鈕隱藏
        resultImg.SetActive(false);
        InvokeRepeating("Time", 1f, 1f); // 在一秒後呼叫Time這個函式，然後每隔一秒就呼叫一次
    }

    void Time(){
        if(time == 0){ // 當倒數計時時間歸0時
            CancelInvoke("Time");  // 停止呼叫這個延遲function
            resultImg.SetActive(true);
            resultTxt.GetComponent<Text>().text = "遊戲結束"; //顯示遊戲結束畫面
            Invoke("changeResult", 1.3f); // 過1.3秒就執行changeResult這個函示
        }else{
            time -= 1;  // 時間減1
            resultImg.SetActive(false);
        }
    }

    void changeResult(){
        click();
        SceneManager.LoadScene(12);
    }


    // 當題目數量等於6的時候就呼叫一次這個再次隨機一次
    void reStartRandomAll(){
        randomWord = GetRandomWord();
        randomColor = GetRandomColor();
        topic = 0;
    }


    // 更新按鈕上的字與顏色（因為裡面語法重複性太高，所以就把他們拿出來用呼叫的方式來減短程式碼）
    void updateButtonAndWord(){
        
        ColorNum(randomColor); // 呼叫ColorNum，並且把上面宣告的randomColor當變數傳進去
        
        int[] randomButton = GetRandomNumButton();

        word.GetComponent<Text>().text = randomWord[topic]; 
        word.GetComponent<Text>().color = randomColor[topic]; 
        
        if(randomButton[0] == 1){
            if(randomWord[topic] != randomColorText){
                button1_Text.GetComponent<Text>().text = randomWord[topic]; 
                button2_Text.GetComponent<Text>().text = randomColorText;
            }else{
                reStartRandomAll();
                button1_Text.GetComponent<Text>().text = randomWord[topic]; 
                button2_Text.GetComponent<Text>().text = randomColorText;
            }
        }
        if(randomButton[0] == 2){
            if(randomWord[topic] != randomColorText){
                button2_Text.GetComponent<Text>().text = randomWord[topic]; 
                button1_Text.GetComponent<Text>().text = randomColorText;
            }else{
                reStartRandomAll();
                button2_Text.GetComponent<Text>().text = randomWord[topic]; 
                button1_Text.GetComponent<Text>().text = randomColorText;
            }
        }
    }

    // 延遲換題目
    void delayChange(){
        updateButtonAndWord();
        msgTxt.GetComponent<Text>().text = "";
        CancelInvoke("delayChange"); // 關掉延遲這個function
    }

    // 按下右邊的按鈕
    public void onCilckRightButton(){
        // 如果題目已經六題的話就呼叫reStartRandomAll開始隨機一組新的文字與顏色
        if(topic == 6){
            reStartRandomAll();
        }
        if(button2_Text.GetComponent<Text>().text == randomColorText){
            topic++; // 題目+1
            global.dm_total_count++;
            msgTxt.GetComponent<Text>().text = "";
            updateButtonAndWord();
        }else{
            topic++;
            global.dm_total_miss++;
            msgTxt.GetComponent<Text>().text = "點錯囉";
            Invoke("delayChange", 0.3f);  //延遲0.3秒再執行delayChange這個函式
        }
    }

    // 按下左邊的按鈕
    public void onCilckLeftButton(){
        if(topic == 6){
            reStartRandomAll();
        }
        if(button1_Text.GetComponent<Text>().text == randomColorText){
            topic++;
            global.dm_total_count++;
            msgTxt.GetComponent<Text>().text = "";
            updateButtonAndWord();
        }else{
            topic++;
            global.dm_total_miss++;
            msgTxt.GetComponent<Text>().text = "點錯囉";
            Invoke("delayChange", 0.3f);
        }
    }


    // 把從隨機陣列出來的顏色轉換成文字（這樣才能在按鈕上更新文字）
    void ColorNum(Color[] randomColor){ 
        if (randomColor[topic] == redColor){
            randomColorText = "紅";
        }
        if(randomColor[topic] == orangeColor){
            randomColorText = "橙";
        }
        if(randomColor[topic] == yellowColor){
            randomColorText = "黃";
        }
        if(randomColor[topic] == greenColor){
            randomColorText = "綠";
        }
        if(randomColor[topic] == blueColor){
            randomColorText = "藍";
        }
        if(randomColor[topic] == indigoColor){
            randomColorText = "靛";
        }
        if(randomColor[topic] == purpleColor){
            randomColorText = "紫";
        }
    }



    // 匯出Excel
    public void click()
    {
        //寫入Final_4.xlsx，頁面名稱為"心眼不一"
        WriteExcel("Final_4.xlsx", "心眼不一");
    }

    public static void WriteExcel(string excelName, string sheetName)
    {
        //excel的路徑
        string path = excelName;
        FileInfo newFile = new FileInfo(path);
        int flag = 0; //記錄EXCEL是否已經存在， 0為不存在、1為存在

        if (newFile.Exists)
        {
            flag = 1;
        }
        else
        {
            flag = 0;
        }

        //通過ExcelPackage打開文件
        using (ExcelPackage package = new ExcelPackage(newFile))
        {
            ExcelWorksheet worksheet;
            int row_count = 0;// 剛開始的列數為0
            if (flag == 0)
            {
                //加入新的頁面，名稱為sheetName
                worksheet = package.Workbook.Worksheets.Add(sheetName);
                //加入列名
                worksheet.Cells[row_count + 1, 1].Value = "日期";
                worksheet.Cells[row_count + 1, 2].Value = "姓名";
                worksheet.Cells[row_count + 1, 3].Value = "答對題數";
                worksheet.Cells[row_count + 1, 4].Value = "答錯題數";
                row_count = 1;
                worksheet.Cells[row_count + 1, 1].Value = System.DateTime.Now.ToString("MM/dd");
                worksheet.Cells[row_count + 1, 2].Value = global.dm_name;
                worksheet.Cells[row_count + 1, 3].Value = global.dm_total_count;
                worksheet.Cells[row_count + 1, 4].Value = global.dm_total_miss;
            }
            else
            {
                if(package.Workbook.Worksheets[sheetName] == null){  // 判斷心眼不一這個活頁簿在不在，如果不在的話就新增一個
                    worksheet = package.Workbook.Worksheets.Add(sheetName);
                    //加入列名
                    worksheet.Cells[row_count + 1, 1].Value = "日期";
                    worksheet.Cells[row_count + 1, 2].Value = "姓名";
                    worksheet.Cells[row_count + 1, 3].Value = "答對題數";
                    worksheet.Cells[row_count + 1, 4].Value = "答錯題數";
                    row_count = 1;
                    worksheet.Cells[row_count + 1, 1].Value = System.DateTime.Now.ToString("MM/dd");
                    worksheet.Cells[row_count + 1, 2].Value = global.dm_name;
                    worksheet.Cells[row_count + 1, 3].Value = global.dm_total_count;
                    worksheet.Cells[row_count + 1, 4].Value = global.dm_total_miss;
                }else{
                    worksheet = package.Workbook.Worksheets[sheetName];//選擇已有的頁面sheetName
                    row_count = worksheet.Dimension.Rows;//算出目前頁面的列數
                    worksheet.Cells[row_count + 1, 1].Value = System.DateTime.Now.ToString("MM/dd");
                    worksheet.Cells[row_count + 1, 2].Value = global.dm_name;
                    worksheet.Cells[row_count + 1, 3].Value = global.dm_total_count;
                    worksheet.Cells[row_count + 1, 4].Value = global.dm_total_miss;
                }
            }
            //儲存
            package.Save();
        }
    }
}