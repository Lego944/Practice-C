// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число обозначающее день недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Этот день выходной :)");

}
else if (number < 1 || number > 7)
{
    Console.WriteLine("В недели только 7 дней!");
}
else
{
    Console.WriteLine("Этот день не выходной :(");
}
