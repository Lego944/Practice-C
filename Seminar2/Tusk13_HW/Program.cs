// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Программа выводит третью цифру указанного числа");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number<0)
{
    Console.WriteLine("Число должно быть положительным");
}
else if(number > 99)
{
    string str = number.ToString();
    int[] b = new int[str.Length];
    for( int i=0; i< str.Length; i++)
    {
         b[i] = int.Parse(str[i].ToString());
    }
    Console.WriteLine($"Третья цифра вашего числа {b[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
