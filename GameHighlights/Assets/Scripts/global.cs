using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class global // 設定全域變數
{
    // 翻牌配對
    public static string mf_name; // 紀錄MF_Main所輸入的名字
    public static int mf_count; // 紀錄翻了幾張牌（超過2就不能再翻）
    public static int mf_total_count; // 紀錄總共翻了幾次
    public static int mf_time; // 紀錄遊玩時間
    public static List<GameObject> mf_flop = new List<GameObject>();  // 紀錄翻出來的兩張牌水果牌
    public static List<GameObject> mf_flop_back = new List<GameObject>();  // 紀錄所翻出來的兩張牌封面
    public static List<GameObject> mf_total_back = new List<GameObject>(); // 記錄所有已經被隱藏掉的封面


    // 猜數字
    public static string gtn_name; // 紀錄GTN_Main所輸入的名字
    public static int gtn_total_count; // 紀錄總共猜了幾次
    public static int gtn_time; // 紀錄遊玩時間
    public static string gtn_level;



    // 眼明手快
    public static string c_name; // 紀錄C_Main所輸入的名字
    public static int c_total_count; // 紀錄總共點了幾次
    public static int c_time; // 紀錄遊玩時間
    public static string c_level;
    public static int highestRecord; // 紀錄最高紀錄

    


    // 心眼不一
    public static string dm_name; // 紀錄在心眼不一首頁所輸入的名字
    public static int dm_total_count; // 紀錄總共答對了幾題
    public static int dm_total_miss; // 紀錄總共打錯了幾題
    


}