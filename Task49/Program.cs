int[,] CreateMatrixRandomInt(int SizeX, int SizeY, int min, int max)
{
    int[,] matrix = new int[SizeX, SizeY];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }

        Console.WriteLine("|");
    }
}

void EvenNumbersCubedInMatrix(int[,] matrixCubed)
{
    for (int i = 0; i < matrixCubed.GetLength(0); i++)
    {
        for (int j = 0; j < matrixCubed.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                matrixCubed[i, j] *= matrixCubed[i, j];
        }
    }

}

int[,] array2D = CreateMatrixRandomInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
EvenNumbersCubedInMatrix(array2D);
PrintMatrix(array2D);
