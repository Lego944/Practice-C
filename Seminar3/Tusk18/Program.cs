// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите нормер координатной четверти:");
int numCor = Convert.ToInt32(Console.ReadLine());

if ( numCor < 5 && numCor > 0)
{
    if (numCor == 1)
    {
        Console.WriteLine("X > 0 и Y > 0");
    }
    if (numCor == 2)
    {
        Console.WriteLine("X < 0 и Y > 0");
    }
    if (numCor == 3)
    {
        Console.WriteLine("X < 0 и Y < 0");
    }
    if (numCor == 4)
    {
        Console.WriteLine("X > 0 и Y < 0");
    }
}
else
{ 
    Console.WriteLine("Введено число больше диапазона четверти или отрицательное");
}