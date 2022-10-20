void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число");
        int m = Convert.ToInt32(Console.ReadLine());
        array[i] = m;
    }
}
int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите количество чисел в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[] NewArray = new int[n];
FillArray(NewArray);
Console.WriteLine($"Ваш массив: [{String.Join(" ,",NewArray )}]");
Console.WriteLine("Количество чисел больше нуля равно: " + Counter(NewArray));