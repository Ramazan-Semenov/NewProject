﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
namespace menu.Models.ModelDB
{
    class SaveExcel
    {
        public void Save(DataGrid dataGrid)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

            for (int j = 0; j < dataGrid.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[1, j + 1];
                sheet1.Cells[1, j + 1].Font.Bold = true;
                sheet1.Columns[j + 1].ColumnWidth = 15;
                myRange.Value2 = dataGrid.Columns[j].Header;
            }
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                for (int j = 0; j < dataGrid.Items.Count; j++)
                {
                    TextBlock b = dataGrid.Columns[i].GetCellContent(dataGrid.Items[j]) as TextBlock;
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = b.Text;
                }
            }
        }
    }
}
