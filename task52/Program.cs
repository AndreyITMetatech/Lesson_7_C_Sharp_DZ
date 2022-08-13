// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int m = 0;
int n = 0;
Console.WriteLine("Введите m");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите n");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine();

int[,] array = new int[m, n];
double sum = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++) array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
            sum += array[i, j];
            if (j == n - 1) Console.Write($" {sum / n}");
        }
        Console.WriteLine();
    }
}
PrintArray(array);