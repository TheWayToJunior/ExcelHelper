using ExcelManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager
{
    public interface IExcelManager
    {
        /// <summary>
        /// Получает название всех Sheets в указанном Excel файле
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Возвращает колекцию имен WorkSheets</returns>
        ExcelResponse GetNameWorkSheets(string path);

        /// <summary>
        /// Выполняет копирование указаного Sheet из однго файла Excel в другой
        /// </summary>
        /// <param name="where"></param>
        /// <param name="from"></param>
        /// /// <param name="indexSheet"></param>
        /// <returns>Возвращает true в том случае если копирование выполнено успешно, иначе вернется false</returns>
        bool Copy(string where, string from, int indexSheet = 1);

        /// <summary>
        /// Сравнивает два в указанных файлах Excel
        /// </summary>
        /// <param name="mainObj">Файл в котором по итогу выполянея будет записат результат в виде нового WorkSheet</param>
        /// <param name="comparedObj"></param>
        void Compare(ExcelWork mainObj, int mainRowIndex, ExcelWork comparedObj, int comparedRowIndex);
    }
}
