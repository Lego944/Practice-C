// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int EvenArrayNumbers(int[] arr)
{
    int Count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            Count = Count + 1;
        }
    }
    return Count;
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите размера массива:");
int[] EvenCount = GetArray(number, 100, 999);
Console.WriteLine("Создан случайный массив.");
Console.WriteLine(string.Join(", ", EvenCount));
int result = EvenArrayNumbers(EvenCount);
Console.WriteLine($"Количесвто четных чисел в массиве = {result}");
