// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Вариант решения 1. После просмотра семенара 4.

// Console.WriteLine("Введите пятизначное число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int temp = number;
// int revers = 0;
// if (number < 0)
// {
//     Console.WriteLine("Число должно быть положительным!");
// }
// else if (number > 9999 && number < 100000)
// {
//     while(temp > 0)
//     {
//         int digit = temp % 10;
//         revers = revers * 10 + digit;
//         temp = temp / 10;
//     }
//     if (revers == number)
//     {
//         Console.WriteLine($"Число {number} является палиндромом.");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number} не является палиндромом.");
//     }
// }    
// else 
// {
//     Console.WriteLine("Число должно быть пятизначным!");
// }

//Вариант решения 2. Самостоятельный без гугл.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Число должно быть больше нуля!");
}
else if (number > 9999 && number < 100000)
{
    int number1 = number / 10000;
    int number5 = number % 10;

        if (number1 == number5)
        {
            int number2 = (number / 1000) % 10;
            int number4 = (number / 10) % 10;

            if (number2 == number4)
            {
                Console.WriteLine($"Число {number} является палиндромом.");
            }
             else 
            {
                Console.WriteLine($"Число {number} не является палиндромом.");
            }  
        }
        else 
        {
            Console.WriteLine($"Число {number} не является палиндромом.");
        }
        
    
}
else
{
    Console.WriteLine("Введите пятизначное число!");
}

