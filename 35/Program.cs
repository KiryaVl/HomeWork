// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5

int[] FillArray(int size)
{
    int[] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 1000);
    }
    return arr;
}
int num = 123;
int[] array = FillArray(num);
Console.WriteLine("Массив: " + string.Join(", ", array));
int num2 = 0;
for (int i = 0; i < array.Length; i++)
{
    while (array[i] <= 99 && array[i] >= 10 )
    {
        num2+=1;
        break;
    }
}
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {num2} ");