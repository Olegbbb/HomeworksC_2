void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите количетво строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетво столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] random = new double[m, n];
FillMatrix(random);