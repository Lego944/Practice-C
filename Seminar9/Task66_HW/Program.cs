// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int DigitSumMN(int m, int n)
{
    if (n < m)
    {
        return 0;
    }
    else
    {
        return n + DigitSumMN(m, n - 1);
    }
}

int numberM = ReadNumber("Введите M: ");
int numberN = ReadNumber("Введите N: ");

if (numberN > numberM)
{
    Console.Write(DigitSumMN(numberM, numberN));
}
if (numberN < numberM)
{
    Console.Write(DigitSumMN(numberN, numberM));
}
