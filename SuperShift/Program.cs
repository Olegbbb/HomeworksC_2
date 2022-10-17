void NewArray ( int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random(). Next(0,10);
    }
}
Console.WriteLine("Введите количество элементов ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Введите число К");
int k = Convert.ToInt32(Console.ReadLine());
if (k < 0)
{
    k = -k;
    k = k % n;
}
else
{
    k = k % n;
    k = n - k;
}
Console.WriteLine($"Первоначальная последовательность [{string.Join(" ," ,array)}]");
for (int i = k; i < n; i++)
{
    Console.Write(" " + array[i]);
}
for (int i = 0; i < k; i++ )
{
    Console.Write(" " + array[i]);
}