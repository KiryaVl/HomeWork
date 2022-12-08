// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// С = A · B = 4 2 · 3	1  = 6  12                       
//             9 0  -3 4    27	 9                        

// Элементы матрицы C вычисляются следующим образом:
// c11 = a11·b11 + a12·b21 = 4·3 + 2·(-3) = 12 - 6 = 6
// c12 = a11·b12 + a12·b22 = 4·1 + 2·4 = 4 + 8 = 12
// c21 = a21·b11 + a22·b21 = 9·3 + 0·(-3) = 27 + 0 = 27
// c22 = a21·b12 + a22·b22 = 9·1 + 0·4 = 9 + 0 = 9

int[,] FillMatrix(int size, int value)
{
    int[,] matrixA = new int[size, value];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < value; j++)
        {
            matrixA[i, j] = new Random().Next(0, 10);
        }
    }
    return matrixA;
}
void WriteMatrix(int[,] matrixA)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            Console.Write(matrixA[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность массива");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = FillMatrix(m, n);
int[,] matrixB = FillMatrix(m, n);
int[,] matrixC = new int[m, n];
WriteMatrix(matrixA);
Console.WriteLine("-------------------------------------");
WriteMatrix(matrixB);
Console.WriteLine("-------------------------------------");
if (matrixA.GetLength(0) != matrixB.GetLength(1))
{
    Console.WriteLine("Умножение не возможно!");
}
for (int i = 0; i < matrixA.GetLength(1); i++)
{
    for (int j = 0; j < matrixB.GetLength(0); j++)
    {
        matrixC[i, j] = 0;

        for (int k = 0; k < matrixA.GetLength(0); k++)
        {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}
WriteMatrix(matrixC);