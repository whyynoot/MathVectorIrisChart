using System;
using LinearAlgebra;

namespace VectorDemo
{
    class Program
    {
        static void Main()
        {
            double[] arr = {};
            MathVector firstVector = new MathVector(arr);
            Console.WriteLine("Первый вектор, без изменений: ");
            firstVector.printVector();

            double[] array = { -1.0, 54.9123, 10.001 };
            MathVector secondVector = new MathVector(array);
            Console.WriteLine("Второй вектор, без изменений: ");
            secondVector.printVector();

            try
            {
                Console.WriteLine("Скалярное умножение: {0:F}", firstVector.ScalarMultiply(secondVector));
            }
            catch (Exception e) {
                Console.WriteLine("Произошла ошибка: {0}", e.Message);
            }
            try
            {
                Console.WriteLine("Евклидово расстояние второго до первого: {0:F}", secondVector.CalcDistance(firstVector));
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка: {0}", e);
            }

            try
            {
                Console.WriteLine("Прибавляем 4.1 к первому вектору: ");
                firstVector = (MathVector)firstVector.SumNumber(4.1);
                firstVector.printVector();
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка: {0}", e);
            }

            try
            {
                Console.WriteLine("Складываем новый первый вектор со вторым и записываем результат во второй вектор");
                secondVector = (MathVector)secondVector.Sum(firstVector);
                secondVector.printVector();
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка: {0}", e);
            }
            try
            {
                Console.WriteLine("Через перегрузку оператора *, умножаем второй на первый");
                secondVector = (MathVector)(firstVector * secondVector);
                secondVector.printVector();
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка: {0}", e);
            }

            try
            {
                Console.WriteLine("Через перегрузку оператора /, делим первый на второй");
                secondVector = (MathVector)(firstVector / secondVector);
                secondVector.printVector();
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка: {0}", e);
            }

            try
            {
                Console.WriteLine("Через перегрузку оператора /, второй делим на 2");
                secondVector = (MathVector)(secondVector / 2);
                secondVector.printVector();
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка: {0}", e);
            }
        }
    }
}
