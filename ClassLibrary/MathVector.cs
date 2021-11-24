using System;
using System.Collections;
using System.Text;

namespace LinearAlgebra
{
    public class MathVector : IMathVector
    {
        private double[] dots;

        /// <summary>Конструктор вектора по массиву.</summary>> 
        /// <param name="newDots">Массив из которого будет задаваться вектор</param>
        public MathVector(double[] newDots) {
            dots = new double[newDots.Length];
            for (int i = 0; i < newDots.Length; i++) {
                this.dots[i] = newDots[i];
            }
        }

        /// <summary>
		/// Индексатор для доступа к элементам вектора. Нумерация с нуля.
		/// </summary>
		/// <value>i-ый элемент вектора</value>
		/// <exception cref="Exception">Неверный индексатор.</exception>
        public double this[int i] { 
            get {
                if ((i >= Dimensions) || (i < 0))
                    throw new Exception(message: "Неверный индексатор");
                return dots[i]; } 
            set {
                if ((i >= Dimensions) || (i < 0))
                    throw new Exception(message: "Неверный индексатор");
                dots[i] = value; } 
        }

        /// <summary>Рассчитать длину (модуль) вектора.</summary>
		/// <value>Длина вектора.</value>
        public double Length {
            get {
                double result = 0;
                foreach (double dot in dots)
                    result += dot;
                return Math.Abs(result);
        } }

        /// <summary>
        /// Получить размерность вектора.
        /// </summary>
        /// <value>Количество координат.</value>
        public int Dimensions { get { return dots.Length; } }

        /// <summary>
		/// Вычислить Евклидово расстояние до другого вектора.
		/// </summary>
		/// <param name="vector">Вектор с которым будет производиться нахождение Евклидова растояния.</param>
		/// <returns>Евклидово расстояние.</returns>
		/// <exception cref="Exception">Разные вектора.</exception>
        public double CalcDistance(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
            {
                throw new Exception(message: "Разные вектора");
            }
            else
            {
                double[] arr = new double[Dimensions];
                for (int i = 0; i < Dimensions; i++)
                {
                    arr[i] = this[i] - vector[i];
                }
                return new MathVector(arr).Length;
            }
        }

       /// <summary>
       /// Получить енумаратор
       /// </summary>
       /// <returns>Енумаратор</returns>
        public IEnumerator GetEnumerator()
        {
            return dots.GetEnumerator();
        }

        /// <summary>Покомпонентное умножение с другим вектором.</summary>
		/// <param name="vector">Вектор с которым будет производиться умножение.</param>
		/// <returns>Умноженый на другой вектор.</returns>
		/// <exception cref="Exception">Разные вектора.</exception>
        public IMathVector Multiply(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
            {
                throw new Exception(message: "Разные вектора");
            }
            else
            {
                double[] arr = new double[Dimensions];
                for (int i = 0; i < Dimensions; i++)
                {
                    arr[i] = this[i] * vector[i];
                }
                return new MathVector(arr);
            }
        }

        /// <summary>Покомпонентное умножение на число.</summary>
		/// <param name="number">Число, на которое будет умножатся вектор покомпонетно.</param>
		/// <returns>Вектор с добавленым числом.</returns>
        public IMathVector MultiplyNumber(double number)
        {
            double[] newDots = new double[dots.Length];
            for (int i = 0; i < newDots.Length; i++)
                newDots[i] = dots[i] * number;
            return new MathVector(newDots);
        }

        /// <summary>Скалярное умножение на другой вектор.</summary>
		/// <param name="vector">Вектор с которым будет производиться скалярное умножение.</param>
		/// <returns>Скалярно умноженый с другим вектор.</returns>
		/// <exception cref="Exception">Разные вектора.</exception>
        public double ScalarMultiply(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
            {
                throw new Exception(message: "Разные вектора");
            }
            else
            {
                double result = 0;
                for (int i = 0; i < Dimensions; i++)
                {
                    result += this[i] * vector[i];
                }
                return result;
            }
        }

        /// <summary>Сложение с другим вектором.</summary>
		/// <param name="vector">Вектор с которым будет производиться сложение.</param>
		/// <returns>Сложеный с другим вектор.</returns>
		/// <exception cref="Exception">Разные вектора.</exception>
        public IMathVector Sum(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
            {
                throw new Exception(message: "Разные вектора");
            }
            else {
                double[] arr = new double[Dimensions];
                for (int i = 0; i < Dimensions; i++) {
                    arr[i] = this[i] + vector[i];
                }
                return new MathVector(arr);
            }
        }

        /// <summary>Покомпонентное сложение с числом.</summary>
		/// <param name="number">Число, с которым будет складываться вектор.</param>
		/// <returns>Вектор с добавленым числом.</returns>
        public IMathVector SumNumber(double number)
        {
            double[] newDots = new double[Dimensions];
            for (int i = 0; i < Dimensions; i++)
                newDots[i] = dots[i]+ number;
            return new MathVector(newDots);
        }

        /// <summary>Покомпонентное деление с числом.</summary>
		/// <param name="number">Число, с которым будет покомпонетно делиться вектор.</param>
		/// <returns>Покомпонетно раздленый вектор.</returns>
		/// <exception cref="Exception">Деление на 0.</exception>
        public IMathVector DeivideNumber(double number)
        {
            if (number == 0)
                throw new Exception(message: "Деление на 0.");
            double[] newDots = new double[Dimensions];
            for (int i = 0; i < Dimensions; i++)
                newDots[i] = this[i] / number;
            return new MathVector(newDots);
        }

        /// <summary>Покомпонентное деление с другим вектором.</summary>
		/// <param name="vector">Вектор с которым будет производиться деление.</param>
		/// <returns>Покомпонетно раздленный с другим вектора.</returns>
		/// <exception cref="Exception">Разные вектора.</exception>
		/// <exception cref="Exception">Деление на 0.</exception>
        public IMathVector Devide(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
            {
                throw new Exception(message: "Разные вектора");
            }
            else
            {
                double[] arr = new double[Dimensions];
                for (int i = 0; i < Dimensions; i++)
                {
                    if (vector[i] == 0)
                        throw new Exception("Деление на 0");
                    else
                        arr[i] = this[i] / vector[i];
                }
                return new MathVector(arr);
            }
        }

        /// <summary>
        /// Вывод вектора
        /// </summary>
        public void printVector() {
            if (Length == 0)
            {
                Console.WriteLine("Empty Vector");
            }
            else {
                Console.Write("{ ");
                foreach (double dot in dots)
                    Console.Write("{0:F}, ", dot);
                Console.WriteLine(" }");
            }
        }

        /// <summary>
        /// Перегрузка оператора + для сложения вектора с числом
        /// </summary>
        /// <param name="vector">Вектор с которым будем складывать.</param>
        /// <param name="number">Число, которое будем прибавлять к вектору.</param>
        /// <returns>Сложеный вектор с числом.</returns>
        public static IMathVector operator +(MathVector vector, double number)
        {
            return vector.SumNumber(number);
        }

        /// <summary>
        /// Перегрузка оператора + для сложения вектора с вектором.
        /// </summary>
        /// <param name="vector">Первый вектор для сложения</param>
        /// <param name="secondVector">Второй вектор для сложения</param>
        /// <exception cref="Exception">Разные вектора.</exception>
        /// <returns>Сложные вектора.</returns>
        public static IMathVector operator +(MathVector vector, MathVector secondVector)
        {
            return vector.Sum(secondVector);
        }

        /// <summary>
        /// Перегрузка оператора - для вычитания из вектора числа.
        /// </summary>
        /// <param name="vector">Вектор, из которого будет производиться вычитание.</param>
        /// <param name="number">Число, которое будет вычитаться из вектора.</param>
        /// <returns>Вектор с вычтенным числом.</returns>
        public static IMathVector operator -(MathVector vector, double number)
        {
            return vector.SumNumber(-number);
        }

        /// <summary>
        /// Перегрузка оператора - для покомпонетного вычитания одного вектора из другого.
        /// </summary>
        /// <param name="vector">Первый вектор из которого будет производиться вычитание.</param>
        /// <param name="secondVector">Второй вектор, который будет вычитаться.</param>
        /// <exception cref="Exception">Разные вектора.</exception>
        /// <returns>Вычтенный вектор.</returns>
        public static IMathVector operator -(MathVector vector, MathVector secondVector)
        {
            return vector.Sum(secondVector.MultiplyNumber(-1));
        }

        /// <summary>
        /// Перегрзука оператора / для деления вектора на число.
        /// </summary>
        /// <param name="vector">Вектор, на который будем делить.</param>
        /// <exception cref="Exception">Деление на 0.</exception>
        /// <returns>Поделенный вектор на число.</returns>
        public static IMathVector operator /(MathVector vector, double number)
        {
            return vector.DeivideNumber(number);
        }

        /// <summary>
        /// Перегрузка оператора / для деления вектора на вектор.
        /// </summary>
        /// <param name="vector">Первый вектор, который будет делиться.</param>
        /// <param name="secondVector".>Второй вектор, на который будем делить.</param>
        /// <exception cref="Exception">Разные вектора.</exception>
        /// <exception cref="Exception">Деление на 0.</exception>
        /// <returns>Поделеный вектор.</returns>
        public static IMathVector operator /(MathVector vector, MathVector secondVector)
        {
            return vector.Devide(secondVector);
        }

        /// <summary>
        /// Перегрузка оператора * для умножения вектора на число.
        /// </summary>
        /// <param name="vector">Умножаемый вектор</param>
        /// <param name="number">Число, на котрое мы умножеаем.</param>
        /// <returns>Умноженный на число вектор.</returns>
        public static IMathVector operator *(MathVector vector, double number)
        {
            return vector.MultiplyNumber(number);
        }

        /// <summary>
        /// Перегрузка оператора * для умножения вектора на вектор.
        /// </summary>
        /// <param name="vector">Первый вектор</param>
        /// <param name="secondVector">Второй вектор</param>
        /// <exception cref="Exception">Разные вектора.</exception>
        /// <returns>Умноженный вектор.</returns>
        public static IMathVector operator *(MathVector vector, MathVector secondVector)
        {
            return vector.Multiply(secondVector);
        }
        /// <summary>
        /// Скальнрное умножение векторов.
        /// </summary>
        /// <param name="vector">Первый вектор.</param>
        /// <param name="secondVector">Второй вектор.</param>
        /// <exception cref="Exception">Разные вектора.</exception>
        /// <returns>Скальнрно умноженные вектора.</returns>
        public static double operator %(MathVector vector, MathVector secondVector)
        {
            return vector.ScalarMultiply(secondVector);
        }

        /// <summary>
        /// Перегрузка оператора == для сравнения двух векторов между собой.
        /// </summary>
        /// <param name="vector1">Первый вектор для сравнения.</param>
        /// <param name="vector2">Второй вектор для сравнения.</param>
        /// <returns>Булевое значение, равны ли вектора или нет.</returns>
        public static bool operator ==(MathVector vector1, MathVector vector2)
        {
            bool flag = true;
            if (vector1.Dimensions != vector2.Dimensions)
            {
                flag = false;
            }
            else
            {
                for (int i = 0; i < vector1.Dimensions; ++i)
                {
                    if (vector1[i] != vector2[i])
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }

        /// <summary>
        /// Перегрузка оператора != для сравнения двух векторов.
        /// </summary>
        /// <param name="vector1">Первый вектор для сравнения.</param>
        /// <param name="vector2">Второй вектор для сравнения.</param>
        /// <returns>Булевое значение, не равны ли вектора или равны.</returns>
        public static bool operator !=(MathVector vector1, MathVector vector2)
        {
            bool flag = false;
            if (vector1.Dimensions != vector2.Dimensions)
            {
                flag = true;
            }
            else
            {
                for (int i = 0; i < vector1.Dimensions; ++i)
                {
                    if (vector1[i] != vector2[i])
                    {
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }
    }
    
}
