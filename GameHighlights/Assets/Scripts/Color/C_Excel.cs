using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Excel;
using System.Data;
using System.IO;
using OfficeOpenXml;

public class C_Excel : MonoBehaviour
{
    public void click()
    {
        //寫入Final_14.xlsx，頁面名稱為"眼明手快"
        WriteExcel("Final_14.xlsx", "眼明手快");
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
                worksheet.Cells[row_count + 1, 3].Value = "點擊次數";
                worksheet.Cells[row_count + 1, 4].Value = "遊玩時間";
                worksheet.Cells[row_count + 1, 5].Value = "成績";
                row_count = 1;
                worksheet.Cells[row_count + 1, 1].Value = System.DateTime.Now.ToString("MM/dd");
                worksheet.Cells[row_count + 1, 2].Value = global.c_name;
                worksheet.Cells[row_count + 1, 3].Value = global.c_total_count;
                worksheet.Cells[row_count + 1, 4].Value = global.c_time;
                worksheet.Cells[row_count + 1, 5].Value = global.c_level;
            }
            else
            {
                if(package.Workbook.Worksheets[sheetName] == null){  // 判斷猜數字這個活頁簿在不在，如果不在的話就新增一個
                    worksheet = package.Workbook.Worksheets.Add(sheetName);
                    //加入列名
                    worksheet.Cells[row_count + 1, 1].Value = "日期";
                    worksheet.Cells[row_count + 1, 2].Value = "姓名";
                    worksheet.Cells[row_count + 1, 3].Value = "點擊次數";
                    worksheet.Cells[row_count + 1, 4].Value = "遊玩時間";
                    worksheet.Cells[row_count + 1, 5].Value = "成績";
                    row_count = 1;
                    worksheet.Cells[row_count + 1, 1].Value = System.DateTime.Now.ToString("MM/dd");
                    worksheet.Cells[row_count + 1, 2].Value = global.c_name;
                    worksheet.Cells[row_count + 1, 3].Value = global.c_total_count;
                    worksheet.Cells[row_count + 1, 4].Value = global.c_time;
                    worksheet.Cells[row_count + 1, 5].Value = global.c_level;
                }else{
                    worksheet = package.Workbook.Worksheets[sheetName];//選擇已有的頁面sheetName
                    row_count = worksheet.Dimension.Rows;//算出目前頁面的列數
                    worksheet.Cells[row_count + 1, 1].Value = System.DateTime.Now.ToString("MM/dd");
                    worksheet.Cells[row_count + 1, 2].Value = global.c_name;
                    worksheet.Cells[row_count + 1, 3].Value = global.c_total_count;
                    worksheet.Cells[row_count + 1, 4].Value = global.c_time;
                    worksheet.Cells[row_count + 1, 5].Value = global.c_level;
                }
                
                
            }
            //儲存
            package.Save();
        }
    }
}
