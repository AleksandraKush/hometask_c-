int[,] CreatecolumnsatrixRnaInt(int rows, int columns, int max, int min)
{
    int[,] matrix = new int[rows, columns];
    int s = 1;
    while(s < max)
    {
        for (int y = 0; y < rows; y++)
        {
            matrix[0, y] = s;
            s++;
        }
        for (int x = 1; x < columns; x++)
        {
            matrix[x, rows - 1] = s;
            s++;
        }
        for (int y = rows - 2; y >= 0; y--)
        {
            matrix[columns - 1, y] = s;
            s++;
        }
        for (int x = columns - 2; x > 0; x--)
        {
            matrix[x, 0] = s;
            s++;
        }
    }
    return matrix;
}

void Printcolumnsatrix(int[,] columnsatrix)
{
    for (int i = 0; i < columnsatrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < columnsatrix.GetLength(1); j++)
        {
            if (j < columnsatrix.GetLength(1) - 1) Console.Write($"{columnsatrix[i, j],5} ");
            else Console.Write($"{columnsatrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2 = CreatecolumnsatrixRnaInt(4, 4, 1, 16);
Printcolumnsatrix(array2);