# GameHighlights
大二下－Unity期末專題

### 使用技術

| 使用技術    | 
|:-----------| 
| C#         |
| Unity 3D   | 

### 成員

| 成員  | 負責項目 | 
|:-----------| :-----------| 
| 吳宇晞        | 心眼不一、畫面設計 |
| **李姍珊**   | 翻牌配對、眼明手快、統整整個專案 | 
| 簡彣倞   | 猜數字、文件編排 | 

### 專案名稱與專案簡述
此專案共分成4個小專案，分別有翻牌配對、猜數字、心眼不一、眼明手快，分別說明如下：

### 使用者介面流程與技術簡述
#### **Build Settings場景順序**
![image](https://github.com/shan-233/GameHighlights/assets/106702800/6cbcd27c-bc4f-485e-9e30-01a82a5b7951)

#### **首頁**
畫面上分別放了四個按鈕，點擊對應的按鈕就會導至對應的遊戲畫面首頁。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/de10f62f-ca6d-4690-8af6-7c058445680e)

#### **翻牌配對**
這是一款考驗玩家記憶力的遊戲，遊戲共有12張牌，分別是兩兩一組的水果圖，遊戲開始時這12張牌會隨機打亂順序，一次限制只能翻兩張，若翻出兩張一樣的水果圖就會顯示在遊戲上，反之兩張不一樣的圖則會蓋回去，直到所有牌都顯示於遊戲上遊戲即結束。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/13e963ac-28dd-4bde-8978-88a7c047c649)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/eaf9750c-faba-4df7-b049-5c393eac94b3)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/a0526eed-3788-4462-b6c1-77a494882841)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/b73d6859-af4c-46e9-8f08-4cf5eb12f027)

#### **猜數字**
這是一個考驗運氣的遊戲，遊戲可輸入0至99的數字，過程中會依照玩家輸入的數字判斷大小給出提示，且依照輸入的次數、遊戲時間作為成績計算。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/f5f19f5d-071c-45d9-aabd-4e154fefb01f)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/8266f50a-d12b-44be-bb03-ac3e64ebfd5f)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/0f4b9e44-9fea-442b-a1db-f6668de114f4)

#### **心眼不一**
這是一款考驗玩家反應力與思考力的遊戲，遊戲會隨機出現紅橙黃綠藍靛紫7種文字搭配上不同顏色（例：紅、藍），遊戲時間為短短的15秒，在這期間需要快速的反應點擊正確的顏色，若點擊錯誤則點錯次數+1，時間到遊戲即結束。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/fa4a5a3b-e3bc-4910-8e5d-e6a7bf4645d3)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/273a73da-1b24-4434-8693-c7122ce748c3)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/a8b7147c-9deb-43c4-8c6a-bcc67ef0256a)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/1590c413-8e5f-4e7f-9ef9-84ad7321a9a0)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/00523cfe-dea8-4c1d-a61e-228ef5911c24)

#### **眼明手快**
這是一款考驗玩家靈敏度與專注度的遊戲，中間會有一根針會順逆時針移動，針的周圍會有四種顏色，分別為黃紅藍綠，當中間的針為紅色，就必須點擊到紅色的區域，隨著點擊次數的增加，針旋轉的速度也會增加，若沒有正確點到與針對應的顏色區域，則遊戲失敗。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/716746d9-343b-4f4a-96c1-5c5b8ff3b648)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/0168eb1c-808f-46ba-8c4d-f0d62670f109)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/b1c4349f-8a49-4f12-971d-382118d06d9e)

### 參考文獻
1. [Trigger觸發](https://home.gamer.com.tw/creationDetail.php?sn=2300960)
2. [觸發事件 OnTrigger](https://ithelp.ithome.com.tw/m/articles/10261685)
3. [Invoke 概念與用法](https://kcnoteonly.wordpress.com/2018/02/12/unity-%E5%BB%B6%E6%99%82%E5%9F%B7%E8%A1%8C%E5%87%BD%E5%BC%8F%E4%B9%8B-invoke/)
4. [InokeRepeating 概念](https://cindyalex.pixnet.net/blog/post/58464735-unity-c%23-%E7%B0%A1%E6%98%93%E5%80%92%E6%95%B8%E8%A8%88%E6%99%82%E5%99%A8)
5. [OnTriggerStay2D函式沒有每幀都執行問題](https://blog.csdn.net/qq_15020543/article/details/80758835)
6. [碰撞事件概念與用法](https://www.youtube.com/watch?v=2ZPh3P4GE7w)
7. [改變文字顏色的方法](https://blog.csdn.net/weixin_42137574/article/details/102958802)
