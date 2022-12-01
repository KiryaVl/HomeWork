// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите числа: ");
int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);   //Array.ConvertAll - Преобразует массив одного типа в массив другого типа
int sum = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine(sum);