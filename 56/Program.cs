// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] FillMatrix(int size, int value)
{
    int[,] matrix = new int[size, value];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < value; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

int SumString(int[,] matrix, int i)                                     // Новый метод для суммирования элементов строки, что бы уменьшить код.
{
  int sumString = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)                                                 
  {
    sumString += matrix[i,j];
  }
  return sumString;
}


Console.WriteLine("Введите размерность массива");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
WriteMatrix(matrix);
Console.WriteLine("-------------------------------------");
int minSumString = 0;
int sumString = SumString(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = SumString(matrix, i);
  if (sumString > temp)
  {
    sumString = temp;
    minSumString = i;
  }
}
Console.WriteLine($"{minSumString} - строка");