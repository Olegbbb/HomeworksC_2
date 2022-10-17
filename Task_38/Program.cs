void NewArray ( double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random(). Next(0,100);
    }
}
double Max(double[] array)
{
    double m = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > m)
        m = array[i];
    }
    return m;
}
double Min(double[] array)
{
    double m = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < m)
        m = array[i];
    }
    return m;
}
Console.Clear();
double [] myarray = new double[10];
NewArray(myarray);
Console.WriteLine($"Первоначальный массив [{string.Join("   " ,myarray)}]");
Console.WriteLine($"Максимальный элемент равен: {Max(myarray)} , минимальный: {Min(myarray)}");
Console.WriteLine($"Разница макс. и мин. элементов равна: {Max(myarray) - Min(myarray)}");