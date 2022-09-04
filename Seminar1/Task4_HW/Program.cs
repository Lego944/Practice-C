// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите по очереди три числа, чтобы узнать максимальное из них.");

Console.WriteLine("Первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Третье число:");
int numberC = Convert.ToInt32(Console.ReadLine());

int numberMax = Math.Max(numberA, Math.Max(numberB, numberC));

Console.WriteLine($"Максимальное = {numberMax}");

