// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine(number);
int digit2 = number % 10;
int digit1 = number / 10;

// if(digit1 > digit2)
// {
//     Console.WriteLine("Первая цифра больше второй");
// }

// else
// {
//     Console.WriteLine("Вторая цифра больше первой");
// }

if(digit1 > digit2)
{
    Console.WriteLine($"Первая цифра {digit1} больше второй {digit2}");
}
else if(digit1 < digit2)
{
    Console.WriteLine($"Вторая цифра {digit2} больше первой {digit1}");
}

else
{
    Console.WriteLine($"Цифры {digit1} и {digit2} равны");
}
