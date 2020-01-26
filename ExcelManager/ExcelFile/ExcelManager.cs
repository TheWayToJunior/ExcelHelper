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
        public string SavePath { get; set; }

        private Excel.Application excelApp;

        private Excel.Workbook resultBook;

        private Excel.Worksheet resultSheet;

        public ExcelManager(string savePath, string name)
        {
            this.SavePath = savePath + name;

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
                resultBook = excelApp.Workbooks.Add();
                resultBook.SaveAs(SavePath);

                paternBook = excelApp.Workbooks.Open(where);
                (paternBook.Worksheets[1] as Excel.Worksheet).Copy(Before: resultBook.Worksheets[indexSheet]);

                resultBook.Save();

                return true;
            }
            catch (Exception)
            {
                /// Возврат Error Message во View
                /// 
                return false;
            }
            finally 
            {
                resultBook?.Close();
                paternBook?.Close();
            }
        }

        private static int startColumnIndex = 2;

        public void Compare(ExcelWork firstObj, int firstRowIndex, ExcelWork secondObj, int secondRowIndex)
        {
            try
            {
                resultBook = excelApp.Workbooks.Open(SavePath);
                resultSheet = resultBook.Worksheets[1];

                WorkBookManager(firstObj, firstRowIndex);
                WorkBookManager(secondObj, secondRowIndex);

                startColumnIndex++;

                resultBook.Save();
            }
            catch (Exception ex)
            {
                /// Возврат Error Message во View
                /// 
                throw new Exception(ex.Message);
            }
            finally 
            {
                resultBook?.Close();
            }
        }

        private void WorkBookManager(ExcelWork arg, int rowIndex)
        {
            Excel.Workbook comparedBook = null;

            try
            {
                comparedBook = excelApp.Workbooks.Open(arg.FileName);

                /// Получение нужной страницы
                var workSheet = (Excel.Worksheet)comparedBook.Worksheets[arg.WorkSheet];

                dynamic value = ReadSheet(workSheet, arg.Column);

                WriteToNewSheet(value, rowIndex);

            }
            catch (Exception ex)
            {
                /// Возврат Error Message во View
                /// 
                throw new Exception(ex.Message);
            }
            finally
            {
                comparedBook?.Close();
            }
        }

        private dynamic ReadSheet(Excel.Worksheet workSheet, string column) => /// Чтение данных
             workSheet.Range[column].Value2;


        private void WriteToNewSheet(dynamic value, int rowIndex, Color? colorColumn = null)
        {
            if (resultSheet == null)
                throw new NullReferenceException("newSheet is null");

            resultSheet.Cells[rowIndex, startColumnIndex].Value2 = value;
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