// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumN(int N)
{
    int counter = Convert.ToString(N).Length;
    int A = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        A = N - N % 10;
        result = result + (N - A);
        N = N / 10;
    }
    return result;
}

int number = ReadNumber("Введите число, чтобы узнать сумму цифр: ");
int NumberSum = SumN(number);
Console.WriteLine("Сумма цифр в числе: " + NumberSum);
