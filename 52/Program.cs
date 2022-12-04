// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArray(int size, int value)
{
    int[,] matrix = new int[size, value];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < value; j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}
Console.WriteLine("Введите размерность массива");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] newmatrix = FillArray(m, n);
double[] newnewmatrix = new double[m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        newnewmatrix[i] += newmatrix[j, i];
    }
}

for (int i = 0; i < n; i++)
{
    Console.Write((newnewmatrix[i] / m) + " ");
}