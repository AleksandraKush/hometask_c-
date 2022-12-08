Console.WriteLine("введите количество чисел, которое собираетесь вводить");
int size = Convert.ToInt32(Console.ReadLine());

int[] NewArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("введите число");
        array[i] = (Convert.ToInt32(Console.ReadLine()));
    }
    return array;
}

int FindResult(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] massive = NewArray(size);
Console.WriteLine($"Количество чисел, которые больше 0, {FindResult(massive)}");
