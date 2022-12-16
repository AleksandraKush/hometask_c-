Console.WriteLine("введите неотрицательное число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите неотрицательное число N");
int n = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(n, m);
Console.Write(result);

int Akkerman(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    if (number1 > 0 && number2 == 0)
    {
        return Akkerman(number1 - 1, 1);
    }
    return Akkerman(number1 - 1, Akkerman(number1, number2 - 1));
}