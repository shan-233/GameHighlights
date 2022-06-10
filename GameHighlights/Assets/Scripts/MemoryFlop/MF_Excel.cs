using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Excel;
using System.Data;
using System.IO;
using OfficeOpenXml;

public class MF_Excel : MonoBehaviour
{
    public void click()
    {
        //寫入123.xlsx，頁面名稱為"工作表1"
        WriteExcel("33.xlsx", "翻牌配對");
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
                row_count = 1;
                worksheet.Cells[row_count + 1, 1].Value = System.DateTime.Now.ToString("MM/dd");
                worksheet.Cells[row_count + 1, 2].Value = global.mf_name;
                worksheet.Cells[row_count + 1, 3].Value = global.mf_total_count;
                worksheet.Cells[row_count + 1, 4].Value = global.mf_time;
            }
            else
            {
                if(package.Workbook.Worksheets[sheetName] == null){
                    //加入新的頁面，名稱為sheetName
                    worksheet = package.Workbook.Worksheets.Add(sheetName);
                    //加入列名
                     worksheet.Cells[row_count + 1, 1].Value = "日期";
                    worksheet.Cells[row_count + 1, 2].Value = "姓名";
                    worksheet.Cells[row_count + 1, 3].Value = "點擊次數";
                    worksheet.Cells[row_count + 1, 4].Value = "遊玩時間";
                    row_count = 1;
                    worksheet.Cells[row_count + 1, 1].Value = System.DateTime.Now.ToString("MM/dd");
                    worksheet.Cells[row_count + 1, 2].Value = global.mf_name;
                    worksheet.Cells[row_count + 1, 3].Value = global.mf_total_count;
                    worksheet.Cells[row_count + 1, 4].Value = global.mf_time;
                }else{
                    worksheet = package.Workbook.Worksheets[sheetName];//選擇已有的頁面sheetName
                    row_count = worksheet.Dimension.Rows;//算出目前頁面的列數
                    worksheet.Cells[row_count + 1, 1].Value = System.DateTime.Now.ToString("MM/dd");
                    worksheet.Cells[row_count + 1, 2].Value = global.mf_name;
                    worksheet.Cells[row_count + 1, 3].Value = global.mf_total_count;
                    worksheet.Cells[row_count + 1, 4].Value = global.mf_time;
                }
            }

            //儲存
            package.Save();
        }
    }
}

