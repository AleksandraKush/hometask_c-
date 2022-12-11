int[,] CreateMatrixRnaInt (int rows, int columns, int min, int max)
{
    int[,] matrix1 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
             matrix1[i, j] = rnd.Next(min, max +1);
        }
    }
    return matrix1;
}

int[,] CreateMatrixRnaIntSecond (int rows, int columns, int min, int max)
{
    int[,] matrix1 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
             matrix1[i, j] = rnd.Next(min, max +1);
        }
    }
    return matrix1;
}
void PrintMatrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (j < matrix1.GetLength(1) - 1) Console.Write($"{matrix1[i, j],  5} ");
            else Console.Write($"{matrix1[i, j],  5}");
        }
        Console.WriteLine("]");
    }
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            newMatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newMatrix;
}


int[,] array2 = CreateMatrixRnaInt(6, 4, 1, 10);
PrintMatrix(array2);
Console.WriteLine();
int[,] array3 = CreateMatrixRnaIntSecond(4, 3, 1, 10);
PrintMatrix(array3);
Console.WriteLine();
if (array2.GetLength(1) == array3.GetLength(0))
{
    int[,] array4 = MultiplicationMatrix(array2, array3);
    PrintMatrix(array4);
}
else Console.WriteLine("умножение невозможно");