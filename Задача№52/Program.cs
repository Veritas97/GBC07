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

void IntegerNumbersInMatrix(int[,] arr2D,int numX)
{
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            avarage = (avarage + arr2D[i, j]);
        }
        avarage = avarage / numX;
        Console.Write(avarage + "; ");
    }
}

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRandomInt(rows, colums, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
IntegerNumbersInMatrix(array2D,rows);
