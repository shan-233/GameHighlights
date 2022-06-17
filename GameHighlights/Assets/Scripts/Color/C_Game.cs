using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_Game : MonoBehaviour
{
    public GameObject wp; //中間的桿子
    public GameObject txt_count; // 次數
    public GameObject txt_time; // 遊戲時間
    public GameObject GameResult; // 遊戲結果
    public GameObject txt_record;
    int random; // 用數字紀錄顏色，1紅、2藍、3綠、4黃
    int randomCount; // 紀錄點擊次數
    int c_rotate = 0; // 拿來判斷是否要繼續轉的值
    int stay2D; // 拿來記錄目前跑到哪一塊
    float speed = 0.2f;
    int addcount = 5;

    void Start()
    {
        c_rotate = 0;
        speed = 0.2f;
        addcount = 5;
        transform.Rotate(0,0,speed);
        global.c_total_count = 0; //初始化次數
        global.c_time = 0; // 初始化時間

        txt_record.GetComponent<Text>().text = global.highestRecord.ToString();

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

        InvokeRepeating("timeCount", 1f, 1f);
    }


    void Update()
    {
        txt_count.GetComponent<Text>().text = global.c_total_count.ToString(); //更新count顯示到Text上
        txt_time.GetComponent<Text>().text = global.c_time.ToString();
        
        if(global.c_total_count > global.highestRecord){
                global.highestRecord = global.c_total_count;
                txt_record.GetComponent<Text>().text = global.highestRecord.ToString();
        }

        if(c_rotate == 1){
            if(global.c_total_count > global.highestRecord){
                global.highestRecord = global.c_total_count;
            }
            transform.Rotate(0,0,0);
            GameResult.SetActive(true);
        }else{
            // 判斷針轉的方向
            if(global.c_total_count <= addcount){
                if(randomCount % 2 == 0){ //如果次數是雙數，就順時針轉
                    transform.Rotate(0,0,speed);
                }else{
                    transform.Rotate(0,0,-speed);  //次數是單數，就逆時針轉
                }
            }
            
            if(global.c_total_count == addcount){ // 如果次數跟addcount一樣，就加0.2f速度
                addcount += 5;
                speed += 0.2f;
            }
            GameResult.SetActive(false);
        }
    
        // 根據目前指針在哪一個區塊去進行判斷
        if(Input.GetMouseButtonDown(0)){
            if(stay2D == 1){
                oneClickRed();
            }
            if(stay2D == 2){
                oneClickBlue();
            }
            if(stay2D == 3){
                oneClickGreen();
            }
            if(stay2D == 4){
                oneClickYellow();
            }
        }
    }


    public void timeCount(){ 
        if(c_rotate == 1){ // 判斷按錯顏色
            CancelInvoke("timeCount"); // 關掉這個呼叫
            // 依照次數判斷級別
            if(global.c_total_count > 35){
                global.c_level = "A";
            }else if(global.c_total_count > 20 && global.c_total_count <= 35){
                global.c_level = "B";
            }else{
                global.c_level = "C";
            }
        }else{
            global.c_time += 1; // 遊玩時間加一秒
        }
    }


    // Unity的Trigger觸發方法，當兩個物件持續接觸時，會不斷執行這個函式
    void OnTriggerStay2D(Collider2D collision)  
    {
        if(collision.gameObject.tag == "red"){ // 如果Tag是紅色
            stay2D = 1; // 傳入參數1至stay2D，好讓Update可以隨時抓取到目前指針位於哪塊顏色上
        }
        
        if(collision.gameObject.tag == "blue"){
            stay2D = 2;
        }
        
        if(collision.gameObject.tag == "green"){
            stay2D = 3;
        }
        
        if(collision.gameObject.tag == "yellow"){
            stay2D = 4;
        }
    }


    // 當滑鼠左鍵點擊一下就會執行判斷
    public void oneClickRed(){
        if(Input.GetMouseButtonDown(0)){ //當按下左鍵
            if(random == 1){  // 如果是紅色的話
                global.c_total_count++; // 點擊次數+1
                changeColor(); // 換顏色
            }else{
                c_rotate = 1; // 如果點錯顏色的話就回傳1，讓Update更新成停止旋轉
            }
        }
    }

    public void oneClickBlue(){
        if(random == 2){
            global.c_total_count++;
            changeColor(); // 換顏色
        }else{
            c_rotate = 1;
        }
    }

    public void oneClickGreen(){
        if(random == 3){
            global.c_total_count++;
            changeColor(); // 換顏色
        }else{
            c_rotate = 1;
        }
    }

    public void oneClickYellow(){
        if(random == 4){
            global.c_total_count++;
            changeColor(); // 換顏色
        }else{
            c_rotate = 1;
        }
    }


    // 換顏色的function，EX:假設現在是紅色，那下一個顏色就是黃綠藍其中一個
    public void changeColor(){
        Image img = wp.GetComponent<Image>(); //取的img圖片
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
