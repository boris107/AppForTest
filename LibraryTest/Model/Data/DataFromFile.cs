using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryTest.Model
{
    public static class DataFromFile
    {
        // Метод предназначен для изъятия данных из текстового файла, который возвращает коллекцию данных (Data)
        public static List<Data> GetDataFromFile(string path)        
        {
            List<Data> dataList = new List<Data>();
            try
            {
                // Считываем символы из потока байтов и записываем в модель данных (Data) значения (Тип ИД) и массив параметров
                // Для этого необходимо разбить строку на пробелы и записать данные в модель
                StreamReader sr = new StreamReader(path);
                string line;
                line = sr.ReadLine();                
                while (line != null)
                {
                    Data data = new Data();
                    data.TypeId = int.Parse(line.ElementAt(0).ToString());
                    int i = 0;
                    data.ArrParameters = new int[line.Trim().Split(' ').Length - 1];
                    foreach (var item in line.Trim().Split(' '))
                    {
                        if (i > 0)
                            data.ArrParameters[i - 1] = Convert.ToInt32(item);
                        i++;
                    }
                    dataList.Add(data);
                    line = sr.ReadLine();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dataList;
        }
    }
}
