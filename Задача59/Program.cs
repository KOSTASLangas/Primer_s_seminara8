// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, c];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    matrix[i, j] = new Random().Next(-100, 100);
    Console.Write(matrix[i, j] + " \t");
    }
    Console.WriteLine();
}

int minNumber = 101;
int minRow = 0;
int minColumn = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    if (minNumber > matrix[i,j])
    {
        minNumber = matrix[i,j];
        minRow = i;
        minColumn = j;
    }
    }
    Console.WriteLine();
}
Console.WriteLine("В строке под номером: " + minRow + 1);
Console.WriteLine("В столбце под номером: " + minColumn + 1);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    if (minRow != i && minColumn != j)
        Console.Write(matrix[i, j] + " \t");
    }
    Console.WriteLine();
}