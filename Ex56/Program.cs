// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] array = FillArray(4, 4, 0, 10);
PrintArray(array);

int[] sumArray = Get1DArraySumRowsFrom2DArray(array);
int minValue = sumArray.Min();
int indexMin = Array.IndexOf(sumArray, minValue);

System.Console.WriteLine($"{indexMin + 1}-я строка с наименьшей суммой элементов");

int[,] FillArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write("{0,4}\t", inputArray[i, j]);
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

int[] Get1DArraySumRowsFrom2DArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumArray[i] += array[i, j];
        }
    }

    return sumArray;
}