// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.WriteLine("Введите количество строк массива m:");
int m = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива n:");
int n = Int32.Parse(System.Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-99, 100);
        Console.Write((matrix[i, j] + "\t"), 4);
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Введите строку элемента");
int line = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите столбец элемента");
int column = Int32.Parse(System.Console.ReadLine());
if (line <= matrix.GetLength(0) && column <= matrix.GetLength(1))
{
    System.Console.WriteLine($"По адресу строка {line}, столбец {column} находится число {matrix [line-1, column-1]}");
}
else System.Console.WriteLine("такого числа в массиве нет");