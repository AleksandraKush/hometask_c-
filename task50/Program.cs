int[ , ] CreateMatrixRnaInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

void FindElement(int[,] matrix)
{
    Console.WriteLine("введите строку, в котором хотите найти элемент");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите столбец, в котором хотите найти элемент");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row <= matrix.GetLength(0) && column<= matrix.GetLength(1)) Console.WriteLine(matrix[row - 1, column - 1]);
    else Console.WriteLine("такого элемента в массиве нет");
}

int[,] array2 = CreateMatrixRnaInt(3, 4, 1, 15);
PrintMatrix(array2);
FindElement(array2);