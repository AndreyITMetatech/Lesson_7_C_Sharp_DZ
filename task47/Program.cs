// Задача 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int m = 0;
int n = 0;
Console.WriteLine("Введите m");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите n");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine();

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++) array[i, j] = new Random().NextDouble() * 200 - 100;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) Console.Write(string.Format("{0:0.##}  ", array[i, j]));
        Console.WriteLine();
    }
}

PrintArray(array);