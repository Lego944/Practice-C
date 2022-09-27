// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void MatrixIndexFind(int[,] matrix, int Iind, int Jind)
{
    if (Iind < 0 || Jind < 0)
    {
        Console.WriteLine("Индекс не может быть отрицательным!");
    }

    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == Iind && j == Jind)
                {
                    Console.WriteLine($"В строке с индексом[{Iind}] и стобце с индексом[{Jind}] находится данное значение = {matrix[i, j]}.");
                }
            }
        }
    }
}


int line = ReadNumber("Введите количество строк: ");
int column = ReadNumber("Введите количество столбцов: ");

int[,] matrArr = GetMatrix(line, column);
PrintMatrix(matrArr);

int lineI = ReadNumber("Введите индекс строки: ");
int columnJ = ReadNumber("Введите индекс столбца: ");


if (line - 1 < lineI || column - 1 < columnJ)
{
    Console.WriteLine($"В строке с индексом[{lineI}] и стобце с индексом[{columnJ}] значений нет.");
}
else
{
    MatrixIndexFind(matrArr, lineI, columnJ);
}