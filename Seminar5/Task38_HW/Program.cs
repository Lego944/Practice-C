// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Метод по созданию массива с рандомными значениями.
int[] GetArray(int size,int leftRange,  int rightRange) 
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

// Метод по поиску максимального и минимального значения в массиве.
(int, int) MinAndMaxNumbers(int[] arr)
{
    int numbermax = arr[0];
    int numbermin = arr[0];

    for(int i = 0; i < arr.Length; i++)
    {
       if (numbermin > arr[i])
       {
        numbermin = arr[i];
       }        
       if (numbermax < arr[i])
       {
        numbermax = arr[i];
       }

    }
    return (numbermax, numbermin);
}


int[] array = GetArray(10, 0, 100); // Внесение ограничений рандомно созданного массива.
Console.WriteLine("Массив созданный случайным образом.");
Console.WriteLine("[" + string.Join(", ", array) + "]");
(int max, int min) = MinAndMaxNumbers(array); // Присваиваем переменным значение из метода.
Console.WriteLine($"Максимальные элемент массива = {max}, минимальный элемент массива = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");