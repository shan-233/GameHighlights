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
![image](https://github.com/shan-233/GameHighlights/assets/106702800/bfda9c71-9302-4854-9b2f-38b70d370a8d)

#### **首頁**
畫面上分別放了四個按鈕，點擊對應的按鈕就會導至對應的遊戲畫面首頁。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/8b009ec6-0a2e-42a4-8c7b-15998a72d2ea)

#### **翻牌配對**
這是一款考驗玩家記憶力的遊戲，遊戲共有12張牌，分別是兩兩一組的水果圖，遊戲開始時這12張牌會隨機打亂順序，一次限制只能翻兩張，若翻出兩張一樣的水果圖就會顯示在遊戲上，反之兩張不一樣的圖則會蓋回去，直到所有牌都顯示於遊戲上遊戲即結束。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/2abbc001-f6ed-4ebb-aa96-3e8d2e349c3f)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/662bd184-1a55-488d-aef7-d4d40549d2a6)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/4b80584b-3007-4528-8548-a5bf29f9bc1b)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/d835ea9b-7f94-44e8-9a12-dba0e01f9d1a)

#### **猜數字**
這是一個考驗運氣的遊戲，遊戲可輸入0至99的數字，過程中會依照玩家輸入的數字判斷大小給出提示，且依照輸入的次數、遊戲時間作為成績計算。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/f009e210-a4b3-4719-b7f3-ef1b313f3d1b)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/0fd37613-93b9-4370-9ee3-7adc84f2fd35)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/047897f7-4045-4ddd-9cec-3c0126cf59b3)

#### **心眼不一**
這是一款考驗玩家反應力與思考力的遊戲，遊戲會隨機出現紅橙黃綠藍靛紫7種文字搭配上不同顏色（例：紅、藍），遊戲時間為短短的15秒，在這期間需要快速的反應點擊正確的顏色，若點擊錯誤則點錯次數+1，時間到遊戲即結束。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/29486180-ce3b-4a37-b936-5e91d15e233d)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/f84cd1c7-b07a-418e-8806-64a864fc9a4e)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/6847cf10-d43d-4dd3-b159-ad6b9951920b)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/fd5c8ff2-4e0b-46b3-8077-8d7eb9d6e0f9)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/3592e571-83bf-4441-9950-1ba29efe7abb)

#### **眼明手快**
這是一款考驗玩家靈敏度與專注度的遊戲，中間會有一根針會順逆時針移動，針的周圍會有四種顏色，分別為黃紅藍綠，當中間的針為紅色，就必須點擊到紅色的區域，隨著點擊次數的增加，針旋轉的速度也會增加，若沒有正確點到與針對應的顏色區域，則遊戲失敗。

![image](https://github.com/shan-233/GameHighlights/assets/106702800/c285c55f-e059-42c5-a281-8d10c1365287)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/0de4f553-9ffa-4103-b5fe-3b600055591d)
![image](https://github.com/shan-233/GameHighlights/assets/106702800/2a391fae-35f7-4fc8-aa0f-327459ed29fe)

### 參考文獻
1. [Trigger觸發](https://home.gamer.com.tw/creationDetail.php?sn=2300960)
2. [觸發事件 OnTrigger](https://ithelp.ithome.com.tw/m/articles/10261685)
3. [Invoke 概念與用法](https://kcnoteonly.wordpress.com/2018/02/12/unity-%E5%BB%B6%E6%99%82%E5%9F%B7%E8%A1%8C%E5%87%BD%E5%BC%8F%E4%B9%8B-invoke/)
4. [InokeRepeating 概念](https://cindyalex.pixnet.net/blog/post/58464735-unity-c%23-%E7%B0%A1%E6%98%93%E5%80%92%E6%95%B8%E8%A8%88%E6%99%82%E5%99%A8)
5. [OnTriggerStay2D函式沒有每幀都執行問題](https://blog.csdn.net/qq_15020543/article/details/80758835)
6. [碰撞事件概念與用法](https://www.youtube.com/watch?v=2ZPh3P4GE7w)
7. [改變文字顏色的方法](https://blog.csdn.net/weixin_42137574/article/details/102958802)
