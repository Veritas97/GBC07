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

void SomeElementsMatrix(int[,] arr2d, int numX, int numY)
{
    if (numX > arr2d.GetLength(0) || numY > arr2d.GetLength(1))
    {
        Console.WriteLine("Такого элемента в заданом массиве нет.");
    }
    else
    {
        Console.WriteLine($"Значение элемента {numX} строки и {numY} столбца равно: {arr2d[numX - 1, numY - 1]}");
    }
}

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRandomInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
SomeElementsMatrix(array2D, rows, colums);