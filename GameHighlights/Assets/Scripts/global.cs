using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class global
{
    // 設定全域變數
    public static string mf_name; // 紀錄MF_Main所輸入的名字
    public static int mf_count; // 紀錄翻了幾張牌（超過2就不能再翻）
    public static List<GameObject> mf_flop = new List<GameObject>();  // 紀錄翻出來的兩張牌水果牌
    public static List<GameObject> mf_flop_back = new List<GameObject>();  // 紀錄所翻出來的兩張牌封面
    public static List<GameObject> mf_button = new List<GameObject>();  // 紀錄翻出來的兩張牌水果牌
}