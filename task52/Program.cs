double[,] CreateMatrixRnadouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrdoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],7}");
            else Console.Write($"{matrix[i, j],7}");
        }
        Console.WriteLine("]");
    }
}

double[] FindArithmetic(double[,] matrix)
{
    double[] res = new double[matrix.GetLength(1)];
    int index = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            res[index] += matrix[i, j];
        }
    res[index] = res[index] / matrix.GetLength(0);
    res[index] = Math.Round(res[index], 1);
    index++;
    }
    return res;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],7} ");
        else Console.Write($"{array[i],7}");
    }
}


double[,] array2 = CreateMatrixRnadouble(3, 4, 1, 15);
PrdoubleMatrix(array2);
double[] result = FindArithmetic(array2);
PrintArray(result);