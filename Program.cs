// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillUpArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)   {arr[i] = new Random().Next(100, 1000); }
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) count++;
    }
    return count;
}

int[] array = new int[10];

FillUpArray(array);
Console.WriteLine($"Массив: {String.Join(",", array)}");
Console.WriteLine($"Положительных значений: {CountEvenNumbers(array)}");