/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}

int getSumOfEvenElementInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2 ) == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int []Array = GenerateRandomArray(5, 100, 999);
printArray(Array);
Console.WriteLine();
int SumOfEven = getSumOfEvenElementInArray(Array);
Console.WriteLine($"Сумма четных чисел массива = {SumOfEven}");