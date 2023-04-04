// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = FillArray(rows, columns, 0, 10);
PrintArray(array);

double[] result = Average(array);

Console.WriteLine($"[{String.Join(";  ", result)}]");

//------------вычисление среднего арифметического в каждом столбце--------
double[] Average(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] resArray = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        resArray[j] = Math.Round(sum/rows, 1);
    }
    return resArray;
}

// ----------------Заполнение массива--------------
int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

//---------------Вывод двухмерного массива-----------------
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
}

