using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace IrisChart
{
    class IrisChart
    {
        private readonly int IrisSize = 4;
        private readonly string[] IrisTypes = { "setosa", "virginica", "versicolor" };

        private List<MathVector> setosa = new List<MathVector>();
        private List<MathVector> versicolor = new List<MathVector>();
        private List<MathVector> virginica = new List<MathVector>();

        public MathVector SetosaAverage { get; set; }
        public MathVector VersicolorAverage { get; set; }
        public MathVector VirginicaAverage { get; set; }

        public double DistanceFromSetosaToVersicolor;
        public double DistanceFromSetosaToVirginica;
        public double DistanceFromVersicolorToVirginica;

        /// <summary>
        /// Вычисление всех значений для всех ирисов.
        /// </summary>
        public void SetDistances() {
            DistanceFromSetosaToVersicolor = SetosaAverage.CalcDistance(VersicolorAverage);
            DistanceFromSetosaToVirginica = SetosaAverage.CalcDistance(VirginicaAverage); 
            DistanceFromVersicolorToVirginica = VersicolorAverage.CalcDistance(VirginicaAverage);
        }

        /// <summary>
        /// Проверка на правильное заполненую первую строчку
        /// </summary>
        /// <param name="str">Первая строчка</param>
        private bool CheckFirstLine(string[] str) {
            if (str[0] == "sepal_length" && str[1] == "sepal_width" && str[2] == "petal_length" && str[3] == "petal_width" && str[4] == "species")
                return true;
            else
                throw new Exception(message: "Неверная первая строка!");
        }

        /// <summary>
        /// Проверка на существование данного ириса.
        /// </summary>
        /// <param name="str">Предпологаемые ирис.</param>
        private bool CheckIrisTitle(string str)
        {
            bool flag = false;
            for (int i = 0; i < IrisTypes.Length; i++) {
                if (str == IrisTypes[i])
                    flag = true;
            }
            if (!flag) {
                string message = "Найден несуществующий Iris [" + str + "]";
                throw new Exception(message: message);
            }
            return flag;
        }

        /// <summary>
        /// Передача в вектора в лист ириса.
        /// </summary>
        /// <param name="vector">Вектор, для ириса</param>
        /// <param name="str">Название, ириса</param>
        private void PassToIrisList(MathVector vector, string str) {
            switch (str)
            {
                case "setosa":
                    setosa.Add(vector);
                    break;
                case "versicolor":
                    versicolor.Add(vector);
                    break;
                case "virginica":
                    virginica.Add(vector);
                    break;
            }
        }
        /// <summary>
        /// Парсинг файла, и установка полученных после парсинга данных в ирисы.
        /// </summary>
        /// <param name="csv">Полученные данные из файла.</param>
        public void SetIrisArrays(string[][] csv) {
            double[] temp = new double[IrisSize];
            decimal r;
            if (CheckFirstLine(csv[0]))
            {
                for (int i = 1; i < csv.Length; i++)
                {
                    if (csv[i].Length == IrisSize + 1)
                    {
                        if (CheckIrisTitle(csv[i][IrisSize]))
                        {
                            for (int j = 0; j < IrisSize; j++)
                            {

                                try
                                {
                                    
                                    if (decimal.TryParse(csv[i][j], out r))
                                        temp[j] = double.Parse(csv[i][j]);
                                   
                                    //temp[j] = double.Parse(csv[i][j]);
                                    else
                                        throw new Exception();
                                    Console.WriteLine(temp[j]);
                                }
                                catch
                                {
                                    string message = "Ошибка в строке [" + i.ToString() + "]\n" +
                                            csv[i][j].ToString() + "\nНевозможно преобразовать в число!";
                                    throw new Exception(message: message);
                                }
                                PassToIrisList(new MathVector(temp), csv[i][IrisSize]);
                            }
                        }
                    }
                    else
                    {
                        string message = "Ошибка в строке номер [" + i.ToString() + "] Много данных!";
                        throw new Exception(message: message);
                    }
                }
            }
        }

        /// <summary>
        /// Устанавливает средние значения всех ирисов
        /// </summary>
        public void SetIrisAverages() {
            SetosaAverage = CalculateAverge(setosa);
            VersicolorAverage = CalculateAverge(versicolor);
            VirginicaAverage = CalculateAverge(virginica);
        }

        /// <summary>
        /// Считает среднее значение по переданомму ирису
        /// </summary>
        /// <param name="array">Лист конкретного ириса</param>
        /// <returns>Среднее значение</returns>
        private MathVector CalculateAverge(List<MathVector> array) {
            MathVector average = new MathVector(new double[4]);
           

            for (int i = 0; i < array[0].Dimensions; i++)
            {
                double sum = 0;
                foreach (MathVector item in array)
                {
                    sum += item[i];
                }
                average[i] = sum / array.Count;
            }
            return average;
        }
    }
}
