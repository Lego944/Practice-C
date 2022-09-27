// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void AvgNumbersSum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double avg = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            avg = avg + matrix[j,i];
        }
        Console.Write($"{Math.Round(avg / matrix.GetLength(0), 2)};" + "\t");
    }
}


int line = ReadNumber("Введите количество строк: ");
int column = ReadNumber("Введите количество столбцов: ");

int[,] matrArr = GetMatrix(line, column);
PrintMatrix(matrArr);
AvgNumbersSum(matrArr);