// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] matrixA = FillArray(5, 2, 0, 10);
int[,] matrixB = FillArray(2, 3, 0, 10);

PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);

if (IsMultiMatrix(matrixA, matrixB))
{
    int[,] multiMatrix = GetMultiMatrix(matrixA, matrixB);
    Console.WriteLine("Результирующая матрица будет:");
    PrintArray(multiMatrix);
}


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
            Console.Write("{0,5}\t", inputArray[i, j]);
        }
        Console.WriteLine("");
    }
}

int[,] GetMultiMatrix(int[,] m1, int[,] m2)
{
    int[,] result = new int[m1.GetLength(0), m2.GetLength(1)];
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m2.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < m1.GetLength(1); n++)
            {
                sum += m1[i, n] * m2[n, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}

bool IsMultiMatrix(int[,] m1, int[,] m2)
{
    if (m1.GetLength(1) != m2.GetLength(0))
    {
        Console.WriteLine("Матрицы не могут быть перемножены. Количество столбцов первой матрицы должно равняться количеству строк второй матрицы.");
        return false;
    }
    return true;
}