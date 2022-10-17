Console.Clear();
int max = 1;
int secmax = 0;
int n = 0;
Console.WriteLine("Введите число от 0 до 100");
while (n >= 0 && n <= 100)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n != 0)
    {
        if (n >= max)
        {
            secmax = max;
            max = n;
        }
        else if (n > secmax)
            secmax = n;

    }
     else Console.WriteLine("Второе максимальное число: " + secmax);
}
Console.WriteLine("Вы ввели неверное число");


