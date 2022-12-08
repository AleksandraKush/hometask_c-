double[ , ] CreateMatrixRnaInt (int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
              double num = rnd.NextDouble() * (max - min) + min;
              matrix[i, j] = Math.Round(num, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 7}");
            else Console.Write($"{matrix[i, j],  7}");
        }
        Console.WriteLine("]");
    }
}

double[,] array2 = CreateMatrixRnaInt(3, 4, 1, 15);
PrintMatrix(array2);