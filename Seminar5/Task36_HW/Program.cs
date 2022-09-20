// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Метод по созданию массива с рандомными значениями.
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
// Метод по выводу текста пользователю и ввода числа от пользователя.
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод по нахождению суммы элементов, стоящих на нечётных позициях.
int UnEvenSum(int[] arr)
{
    int sum = 0;
     for(int i = 1; i < arr.Length; i = i +2)
     {
        sum = arr[i] + sum;
     }
     return sum;
}

Console.WriteLine("Находим сумму элементов, стоящик на нечётных позициях.");
int number = ReadNumber("Введите размера массива:");
int Lrange = ReadNumber("Введите диапазон массива ОТ:");
int Rrange = ReadNumber("Введите диапазон массива ДО:");
int[] array = GetArray(number, Lrange, Rrange);
Console.WriteLine("Создан случайный массив.");
Console.WriteLine(string.Join(", ", array));
int result = UnEvenSum(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + result);