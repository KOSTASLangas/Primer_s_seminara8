// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, c];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    matrix[i, j] = new Random().Next(-10, 10);
    Console.Write(matrix[i, j] + " \t");
    }
    Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(1); i++)
{
    int temp = matrix[0, i];
    matrix[0, i] = matrix[n - 1, i];
    matrix[n - 1, i] = temp;
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    Console.Write(matrix[i, j] + " \t");
    }
    Console.WriteLine();
}