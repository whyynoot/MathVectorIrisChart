using System;
using System.Collections;
using System.Text;

namespace LinearAlgebra
{
	public interface IMathVector : IEnumerable
	{
		/// <summary>
		/// Получить размерность вектора.
		/// </summary>
		/// <value>Количество координат.</value>
		int Dimensions { get; }

		/// <summary>
		/// Индексатор для доступа к элементам вектора. Нумерация с нуля.
		/// </summary>
		/// <value>i-ый элемент вектора</value>
		double this[int i] { get; set; }

		/// <summary>Рассчитать длину (модуль) вектора.</summary>
		/// <value>Длина вектора.</value>
		double Length { get; }

		/// <summary>Покомпонентное сложение с числом.</summary>
		/// <param name="number">Число, с которым будет складываться вектор.</param>
		/// <returns>Вектор с добавленым числом.</returns>
		IMathVector SumNumber(double number);

		/// <summary>Покомпонентное деление с числом.</summary>
		/// <param name="number">Число, с которым будет покомпонетно делиться вектор.</param>
		/// <returns>Покомпонетно раздленый вектор.</returns>
		IMathVector DeivideNumber(double number);

		/// <summary>Покомпонентное умножение на число.</summary>
		/// <param name="number">Число, на которое будет умножатся вектор покомпонетно.</param>
		/// <returns>Вектор с добавленым числом.</returns>
		IMathVector MultiplyNumber(double number);

		/// <summary>Сложение с другим вектором.</summary>
		/// <param name="vector">Вектор с которым будет производиться сложение.</param>
		/// <returns>Сложеный с другим вектор.</returns>
		IMathVector Sum(IMathVector vector);

		/// <summary>Покомпонентное умножение с другим вектором.</summary>
		/// <param name="vector">Вектор с которым будет производиться умножение.</param>
		/// <returns>Умноженый на другой вектор.</returns>
		IMathVector Multiply(IMathVector vector);

		/// <summary>Покомпонентное деление с другим вектором.</summary>
		/// <param name="vector">Вектор с которым будет производиться деление.</param>
		/// <returns>Покомпонетно раздленный с другим вектора.</returns>
		IMathVector Devide(IMathVector vector);

		/// <summary>Скалярное умножение на другой вектор.</summary>
		/// <param name="vector">Вектор с которым будет производиться скалярное умножение.</param>
		/// <returns>Скалярно умноженый с другим вектор.</returns>
		double ScalarMultiply(IMathVector vector);

		/// <summary>
		/// Вычислить Евклидово расстояние до другого вектора.
		/// </summary>
		/// <param name="vector">Вектор с которым будет производиться нахождение Евклидова растояния.</param>
		/// <returns>Евклидово расстояние.</returns>
		double CalcDistance(IMathVector vector);
	}
}
