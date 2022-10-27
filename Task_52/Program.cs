void FillMatrix(int[,] matrix)
{   Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колонки");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
double[] sumarray = new double[m];
FillMatrix(matrix);
for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sumarray[i] = (sumarray[i] + matrix[j, i]);
    }
}
for (int i = 0; i < sumarray.Length; i++)
{
    sumarray[i] = Math.Round((sumarray[i] / n), 1);
}

Console.WriteLine($"Среднее арифметическое колонок равно: {String.Join("; ", sumarray)}");
