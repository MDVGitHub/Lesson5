/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random(111, 999).Next(startPoint, endPoint+1);
    }
    return resultArray;
}

int printArray (int[] array)
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    
    Console.Write(Array[i])+",";
}

int i[] GenerateRandomArray()