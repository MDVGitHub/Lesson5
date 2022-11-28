/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}

int getDiffMinOfMaxElementInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i % 2 ) > 0)
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

int []Array = GenerateRandomArray(4, -99, 99);
printArray(Array);
Console.WriteLine();
int DiffOfElements = getDiffMinOfMaxElementInArray(Array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {DiffOfElements}");