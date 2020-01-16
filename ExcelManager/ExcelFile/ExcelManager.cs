using ExcelManager.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace Manager
{
    public class ExcelManager : IExcelManager, IDisposable
    {
        private Excel.Application excelApp;

        private Excel.Workbook mainBook;

        private Excel.Worksheet newSheet;

        public ExcelManager()
        {
            excelApp = new Excel.Application();
        }

        public ExcelResponse GetNameWorkSheets(string path)
        {
            Excel.Workbook workBook = null;
            try
            {
                workBook = excelApp.Workbooks.Open(path);
                var listName = workBook.Worksheets.Cast<Excel.Worksheet>().Select(ws => ws.Name).ToList();

                workBook.Close();

                return new ExcelResponse()
                {
                    FileName = path,
                    Name = path.Split('\\').Last(),
                    WorkSheets = listName
                };
            }
            catch (Exception ex)
            {
                workBook.Close();

                /// Возврат Error Message во View
                /// 
                throw new Exception(ex.Message);
            }
        }

        public bool Copy(string where, string from, int indexSheet = 1)
        {
            Excel.Workbook paternBook = null;

            try
            {
                if (IsOpened(from))
                    throw new Exception("Файл " + from + "уже открыт!");

                mainBook = excelApp.Workbooks.Open(from);

                paternBook = excelApp.Workbooks.Open(where);
                (paternBook.Worksheets[1] as Excel.Worksheet).Copy(Before: mainBook.Worksheets[indexSheet]);

                mainBook.Save();

                mainBook.Close();
                paternBook.Close();

                return true;
            }
            catch (Exception)
            {
                /// Возврат Error Message во View
                /// 
                return false;
            }
        }

        private static int startColumnIndex = 2;

        public void Compare(ExcelWork mainObj, ExcelWork comparedObj)
        {
            Excel.Workbook comparedBook = null;

            try
            {
                if (IsOpened(mainObj.FileName))
                    throw new Exception("Файл " + mainObj.FileName + "уже открыт!");

                mainBook = excelApp.Workbooks.Open(mainObj.FileName);

                newSheet = mainBook.Worksheets[1];

                WorkBookManager(mainBook, mainObj, 4);

                comparedBook = excelApp.Workbooks.Open(comparedObj.FileName);

                WorkBookManager(comparedBook, comparedObj, 6);

                startColumnIndex++;

                mainBook.Save();

                mainBook.Close();
                comparedBook.Close();
            }
            catch (Exception ex)
            {
                /// Возврат Error Message во View
                /// 
                throw new Exception(ex.Message);
            }
        }

        private void WorkBookManager(Excel.Workbook workBook, ExcelWork arg, int rowIndex)
        {
            /// Получение нужной страницы
            var workSheet = (Excel.Worksheet)workBook.Worksheets[arg.WorkSheet];

            dynamic value = ReadSheet(workSheet, arg.Column);

            WriteToNewSheet(value, rowIndex);
        }

        private dynamic ReadSheet(Excel.Worksheet workSheet, string column) => /// Чтение данных
             workSheet.Range[column].Value2;


        private void WriteToNewSheet(dynamic value, int rowIndex, Color? colorColumn = null)
        {
            if (newSheet == null)
                throw new NullReferenceException("newSheet is null");

            newSheet.Cells[rowIndex, startColumnIndex].Value2 = value;
        }

        private IEnumerable CastToDateTime(IEnumerable collection)
        {
            var list = new List<string>();

            foreach (var item in collection)
            {
                try
                {
                    list.Add(DateTime.FromOADate(double.Parse(item.ToString())).ToShortDateString());
                }
                catch
                {
                    list.Add(string.Empty);
                }
            }

            return list;
        }

        private bool IsOpened(string wbook)
        {
            bool isOpened = true;

            Excel.Application exApp;

            exApp = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");

            try
            {
               var ex = exApp.Workbooks.Item[wbook.Split('\\').Last()];
            }
            catch (Exception)
            {
                isOpened = false;
            }

            return isOpened;
        }

        public void Dispose()
        {
            startColumnIndex = 2;

            excelApp.Workbooks.Close();
            excelApp.Quit();
        }
    }
}