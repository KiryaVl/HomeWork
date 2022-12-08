// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int size, int value, int colums)
{
    int[,,] matrix = new int[size, value, colums];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < value; j++)
        {
            for (int k = 0; k < colums; k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return matrix;
}
void WriteMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i,j,k] + $"({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность массива");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = FillMatrix(m,n,z);
Console.WriteLine("-------------------------------------");
WriteMatrix(matrix);
Console.WriteLine("-------------------------------------");