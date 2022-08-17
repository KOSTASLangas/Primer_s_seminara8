// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, c];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    matrix[i, j] = new Random().Next(0, 11);
    Console.Write(matrix[i, j] + " \t");
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
        if (matrix[i,j] != -1)
        {
            int temp = matrix[i,j];
            int z = 0;
            for (int b = 0; b < n; b++)
            {
                for (int d = 0; d < c; d++)
                {
                    if (matrix[b,d] == temp)
                    {
                        matrix[b,d] = -1;
                        z++;
                    }
                }
            }
            Console.WriteLine(temp + " втречается " + z + " раз(а) ");
        }

    }
}