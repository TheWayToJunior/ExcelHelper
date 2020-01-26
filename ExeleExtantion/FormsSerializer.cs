using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ExcelExtantion
{
    class FormsSerializer<T> 
        where T: class, new()
    {
        public string Path { get; private set; }

        public FormsSerializer(string path)
        {
            this.Path = path;
        }

        public void Serialize(T arg, Action<string> ShowMessageError = null)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(Path, FileMode.Create))
            {
                try
                {
                    xmlSerializer.Serialize(fs, arg);
                }
                catch (Exception ex)
                {
                    if (ShowMessageError == null)
                        throw new Exception(ex.Message);

                    ShowMessageError(ex.Message);
                }
            }
        }

        public T Deserialize(Action<string> ShowMessageError = null)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(Path, FileMode.Open))
            {
                T obj = null;

                try
                {
                    obj = (T)xmlSerializer.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    if (ShowMessageError == null)
                        throw new Exception(ex.Message);

                    ShowMessageError(ex.Message);
                }

                return obj;
            }
        }
    }
}
