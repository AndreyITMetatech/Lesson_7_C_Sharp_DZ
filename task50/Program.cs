// Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве, и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// 4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
// 2, 3 -> такой элемент есть и равен 4
// 5, 5 -> такой элемент отсутствует

int m = 10;
int n = 10;
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++) array[i, j] = new Random().Next(0, 100);
}

Console.WriteLine("Введите M1 index: ");
int m1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N1 index: ");
int n1 = int.Parse(Console.ReadLine()!);

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void CheckArray(int[,] array, int m1, int n1)
{
    if (m1 > m || n1 > n)
    {
        Console.WriteLine("Ваш индекс находится вне массива");
        return;
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == m1 - 1 && j == n1 - 1) Console.WriteLine($"Ваш номер {array[i, j]}");
        }
    }
}

PrintArray(array);
Console.WriteLine();
CheckArray(array, m1, n1);