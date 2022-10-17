void NewArray ( int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random(). Next(100,1000);
    }
}

int AmountEvenNumbers (int[] array)
{
    int m = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0)
        m++;
    }
    return m;
}

Console.Clear();
int[] ourArray = new int[10];
NewArray (ourArray);
Console.Write($" Наш массив [{string.Join(", ", ourArray)}]"); 
Console.WriteLine($"  Количество четных чисел в числе равно: {AmountEvenNumbers(ourArray)}");