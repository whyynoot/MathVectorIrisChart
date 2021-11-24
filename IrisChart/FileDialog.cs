using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IrisChart
{
    class FileDialog
    {
        private const long MaximumFileSizeBytes = 17179869184;
        private string[] lines;
        private string[][] csv;

        public string[] Lines 
        {
            get 
            {
                return lines;
            }
        }
        public string[][] Csv
        {
            get
            {
                return csv;
            }
        }

       /// <summary>
       /// Функция открытия файла
       /// </summary>
        public void OpenFile(string filename) 
        {
            string filepath = filename;
            System.IO.FileInfo file = new System.IO.FileInfo(filepath);
            if (file.Length == 0 || file.Length > MaximumFileSizeBytes)
            {
                throw new Exception(message: "Файл пустой, или больше максимально допустимого размера!");
            }
            lines = File.ReadAllLines(filepath);
        }

        /// <summary>
        /// Функция форматирования CSV формата в массив массивов
        /// </summary>
        public void FormatCsv() {
            try
            {
                string[] names = Lines[0].Split(',');
                csv = new string[Lines.Length][];
                csv[0] = names;
                for (int i = 1; i < Lines.Length; i++)
                {
                    csv[i] = Lines[i].Split(',');
                }
            }
            catch
            {
                throw new Exception(message: "Невозможно прочитать файл!");
            }
        }
    }
}
    

