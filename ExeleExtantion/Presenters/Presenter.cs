﻿using ExcelExtantion.Models;
using ExcelManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExcelExtantion.Presenters
{
    class Presenter
    {
        private readonly MainForm view;

        private readonly UserControls.UserControls userControls;

        private Manager.IExcelManager excelManager { get; set; }

        private ExcelResponseModel excelResponse { get; set; }

        private FormsSerializer<List<ExcelWorkModel>> formsSerializer { get; set; }

        private List<ExcelWorkModel> workModels = null;

         public Presenter(MainForm form)
        {
            formsSerializer = new FormsSerializer<List<ExcelWorkModel>>(AppDomain.CurrentDomain.BaseDirectory + @"\data.xml");

            view = form;
            
            userControls = new UserControls.UserControls()
            {
                File = new UserControls.UcFile(),
                Main = new UserControls.UcMain(),
                Options = new UserControls.UcOptions()
            };

            #region События
            view.Load += (s, e) => view.AddControlsToPanel(userControls.File);

            view.btnFilse.Click += (s, e) => view.AddControlsToPanel(userControls.File);

            view.btnMain.Click += (s, e) => view.AddControlsToPanel(userControls.Main);

            view.btnOptions.Click += (s, e) => view.AddControlsToPanel(userControls.Options);

            userControls.File.CompleteEvent += File_CompleteEvent;

            userControls.Main.CreatingRows += Main_CreatingRows;

            userControls.Main.CompleteEvent += Main_CompleteEvent;
            #endregion
        }

        /// <summary>
        /// Загрузка данных перед перехода к UCMain
        /// </summary>
        private void File_CompleteEvent(string path1, string path2)
        {
            this.excelManager = new Manager.ExcelManager(userControls.Options.SavePath, $"Сверка_{DateTime.Now.ToShortDateString()}.xlsx");

            try
            {
                /// Загрузка названий WorkSheets
                excelResponse = new ExcelResponseModel()
                {
                    FirstFile = excelManager.GetNameWorkSheets(path1),
                    SecondFile = excelManager.GetNameWorkSheets(path2)
                };

                if (File.Exists(formsSerializer.Path))
                    userControls.Main.AddDataRows(formsSerializer.Deserialize(view.ShowMessageError)); /// Получение сериализованных данных 

                view.AddControlsToPanel(userControls.Main);

                view.btnMain.Enabled = true;

                view.btnMain.ToChange(ButtonColor.OnClick);
                view.btnFilse.ToChange(ButtonColor.Default);
            }
            catch (Exception ex)
            {
                view.ShowMessageError(ex.Message);
            }
        }

        private ExcelResponseModel Main_CreatingRows() => excelResponse;

        /// <summary>
        /// Основная логика обработки файлов
        /// </summary>
        private void Main_CompleteEvent(DataGridViewRowCollection collection)
        {
            var checkCopy = excelManager.Copy(AppDomain.CurrentDomain.BaseDirectory + "Temp.xlsx", excelResponse.FirstFile.FileName);

            if (!checkCopy)
            {
                ((IDisposable)excelManager).Dispose();

                view.ShowMessageError("Не удалось загрузить шаблон таблицы. Убедитесь что " 
                    + excelResponse.FirstFile.FileName + " закрыт");

                return;
            }

            workModels = new List<ExcelWorkModel>();

            try
            {
                foreach (DataGridViewRow item in collection)
                {
                    var workModel = new ExcelWorkModel();

                    /// Инициализация объекта содержащего основную информацию о первом файле
                    /// на основе полученных данных из первой части таблицы
                    workModel.FirstFile = new ExcelWork()
                    {
                        FileName = excelResponse.FirstFile.FileName,

                        Name = item.Cells["NameColumn1"].Value.ToString(),

                        WorkSheet = item.Cells["NameTable1"].Value.ToString(),

                        Column = item.Cells["Range1"].Value.ToString()
                    };

                    /// Инициализация объекта содержащего основную информацию о втором файле
                    /// на основе полученных данных из второй части таблицы
                    workModel.SecondFile = new ExcelWork()
                    {
                        FileName = excelResponse.SecondFile.FileName,

                        Name = item.Cells["NameColumn2"].Value.ToString(),

                        WorkSheet = item.Cells["NameTable2"].Value.ToString(),

                        Column = item.Cells["Range2"].Value.ToString()
                    };

                    excelManager.Compare(workModel.FirstFile, 4, workModel.SecondFile, 5);

                    /// Добавление объекта в список для дальнейшей сериализации 
                    workModels.Add(workModel);
                }

                formsSerializer.Serialize(workModels);
            }
            catch (Exception ex)
            {
                view.ShowMessageError(ex.Message);
            }
            finally
            {
                ((IDisposable)excelManager).Dispose();
            }

        }
    }
}
