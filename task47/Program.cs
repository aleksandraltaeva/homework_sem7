// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int rows = InPut("Введите количество строк: ");
int columns = InPut("Введите количество столбцов: ");

double[,] array = FillArray(rows, columns, 0, 10);
PrintArray(array);

//----метод: приглашение ко вводу числа-----
int InPut(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

//-------метод: заполнение массива-------
double[,] FillArray(int m, int n, int minValue, int maxValue)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}

//---------метод: вывод массива---------
void PrintArray(double[,] array)
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