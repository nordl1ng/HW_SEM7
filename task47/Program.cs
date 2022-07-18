// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.WriteLine("Введите количество строк массива m:");
int m = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива n:");
int n = Int32.Parse(System.Console.ReadLine());
double[,] matrix = new double [m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [i,j] = Math.Round(new Random().NextDouble()*10-new Random().NextDouble()*10,1);
        Console.Write(matrix[i, j] + "\t");

    }
    System.Console.WriteLine();
}