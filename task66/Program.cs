Console.WriteLine("введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число M");
int m = Convert.ToInt32(Console.ReadLine());

int result = Natural(n, m);
Console.Write(result);

int Natural(int num1, int num2)
{
    if(num1 > num2)
    {
        num1 += Natural(num1 - 1, num2);
    }
    else if(num1 < num2) 
    {
        num1 += Natural(num1 + 1, num2);
    }
    return num1;
}