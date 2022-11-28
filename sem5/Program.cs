/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9]. Найдите сумму отрицательных и 
положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
чисел равна 29, сумма отрицательных равна -20.
*/

int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}
int getSumOfPositiveElementInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
int getSumOfNegativeElementInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
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
int[] array = GenerateRandomArray(5,-9,9);
printArray(array);
int sumOfPositive = getSumOfPositiveElementInArray(array);
int sumOfNegative = getSumOfNegativeElementInArray(array);
Console.WriteLine($"Сумма положительных элементов {sumOfPositive} и сумма отрицательных {sumOfNegative}");
