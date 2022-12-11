int[,] CreateMatrixRnaInt (int rows, int columns, int min, int max)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],  5} ");
            else Console.Write($"{matrix[i, j],  5}");
        }
        Console.WriteLine("]");
    }
}

int[] SumRows(int[,] matrix)
{
    int[] newMatrix = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        newMatrix[i] = sum;
    }
    return newMatrix;
}

int FindRow(int[] array)
{
    int minCount = array[0];
    int row = 0;
    for (int i = 1; i < array.Length; i++)
    {
         if (minCount > array[i]) 
         {
            minCount = array[i];
            row = i +1;
         }
    }
    return row;
}


int[,] array2 = CreateMatrixRnaInt(6, 4, 1, 10);
PrintMatrix(array2);
Console.WriteLine();
int[] array3 = SumRows(array2);
int a = FindRow(array3);
Console.WriteLine($"{a} строка");