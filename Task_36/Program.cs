void NewArray ( int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random(). Next(-100,101);
    }
}

int FindSum(int[] array)
{
    int m = 0;
    for (int i = 1; i < array.Length; i+= 2)
    {
        m = m + array[i];
    }
    return m;
}

Console.Clear();
int [] myarray = new int[10];
NewArray ( myarray);
Console.WriteLine($"Первоначальный массив [{string.Join(" ," ,myarray)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {FindSum(myarray)}");
