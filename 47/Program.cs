// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] FillArray(int size, int value)
{
double [,] matrix = new double [size,value];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < value; j++)
    {
        matrix[i,j]= Convert.ToDouble(new Random().Next(100)/10.0);
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
double [,] newmatrix = FillArray(m,n);