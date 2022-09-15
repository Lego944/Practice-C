// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Degrees(int A, int B)
{
    int result = 1;
    for(int i=1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int numberDegrees = Degrees(numberA, numberB);
Console.WriteLine("Ответ: " + numberDegrees);
