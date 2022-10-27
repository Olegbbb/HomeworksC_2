void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 21);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

string FindNumber(int[,] matrix)
{
    Console.WriteLine("Введите строку");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец");
    int n = Convert.ToInt32(Console.ReadLine());
    if(m > 4 || n > 3)
    return "Такого элемента нет";
    else return "Нужный элемент равен: " + matrix[m,n]; 
}

Console.Clear();
int[,] table = new int[5, 4];
Console.WriteLine("Наш массив: ");
FillMatrix(table);
Console.WriteLine(FindNumber(table));