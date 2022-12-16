Console.WriteLine("введите число N");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumber(number);

void NaturalNumber(int num)
{
    if(num > 0)
    {
    Console.Write($"{num}, ");
    NaturalNumber(num - 1);
    }
}