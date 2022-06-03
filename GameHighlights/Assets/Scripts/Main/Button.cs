using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void goToMemoryFlop(){ //點擊翻牌配對的按鈕觸發這個function
        SceneManager.LoadScene(1); // 到MemoryFlop Scenes
    }
}
