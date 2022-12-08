// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


int[,] FillMatrix(int size, int value)
{
    int[,] matrix = new int[size, value];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < value; j++)
        {

            matrix[i, j] = new Random().Next(1, 10);

        }
    }
    return matrix;
}
void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}
Console.WriteLine("Введите размерность массива");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
int temp = matrix[0, 0];
int [,]  min = new int [1, 2];
Console.WriteLine("-------------------------------------");
WriteMatrix(matrix);
int[,] newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
int k = 0;
int l = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < 0)
        {
            min[i,j] = matrix[i, j];
        }
    }
}
Console.WriteLine("-------------------------------------");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] <= temp)
        {
            min[0, 0] = i;
            min[0, 1] = j;
            temp = matrix[i, j];
        }
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (min[0, 0] != i && min[0, 1] != j)
        {
            newmatrix[k, l] = matrix[i, j];
            l++;
        }
    }
    l = 0;
    if (min[0, 0] != i)
    {
        k++;
    }
}

WriteMatrix(newmatrix);