// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Чтобы узнать сколько чисел введено больше 0, следуйте инструкции дальше.");
Console.WriteLine("Вводите числа через Enter. Чтобы закончить ввод чисел напишите stop.");

int count = 0;
while (true)
{
    string numbers = Console.ReadLine();
    if (numbers == "stop")
    {
        break;
    }
    if (numbers != "stop")
    {
        int num = Convert.ToInt32(numbers);
        if (num > 0)
        {
            count++;
        }
    }
}
Console.WriteLine($"Чисел больше нуля = {count}.");
