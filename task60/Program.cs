int[, ,] CreateMatrixRnaInt (int rows, int columns, int depth)
{
    int[,,] newMatrix = new int[rows, columns, depth];
    int[,,] matrix1 = new int[rows, columns, depth];
    int[,,] matrix2 = new int[rows, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < newMatrix.GetLength(2); k++)
            {
                matrix1[i, j, k] = rnd.Next(10, 100);
                matrix2[i, j, k] = rnd.Next(10, 100);
                if(matrix1[i, j, k] != matrix2[i, j, k]) 
                {
                    newMatrix[i, j, k] = matrix1[i, j, k];
                }
            }
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array2 = CreateMatrixRnaInt(2, 2, 2);
PrintMatrix(array2);