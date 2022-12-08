Console.WriteLine("введите первый угловой кэффициент ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второй угловой коэффициент");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите переменную первого пересечения прямых с осью у");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите переменную второго пересечения прямых с осью у");
double b2 = Convert.ToInt32(Console.ReadLine());

double IntersectionPoint(int a, int b, int c, int d)
{
    double x = (d - c) / (a - b);
    double y = a * x + c;
    return y; 
}

double result = IntersectionPoint(k1, k2, b1, b2);
Console.WriteLine($"({result}; {result})");