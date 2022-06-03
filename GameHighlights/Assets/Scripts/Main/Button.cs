using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 主頁的按鈕
public class Button : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void goToMemoryFlop(){ // 點擊翻牌配對的按鈕觸發這個function
        SceneManager.LoadScene(1); // 到MemoryFlop Scenes
    }
}
