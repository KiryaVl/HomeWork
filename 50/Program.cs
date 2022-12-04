// . Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размерность массива");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите позицию элемента");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую позицию элемента");
int v = Convert.ToInt32(Console.ReadLine());
if (l > m || v > n)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Такого элемента нет");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(matrix[l,v]);
    Console.ResetColor();
}

