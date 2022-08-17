// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());

if (n == c)
{
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
    for (int j = 0; j < c; j++)
    if (j < i)
    {
    int temp = matrix[i, j];
    matrix[i, j] = matrix[j, i];
    matrix[j, i] = temp;
    }
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
}
else 
Console.WriteLine("Увы... Это невозможно");