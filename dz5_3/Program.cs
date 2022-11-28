/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}

double MaxElementArray (double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinElementArray (double [] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double getDiffMinOfMaxElementInArray(double max, double min)
{
    double diff = max - min;
    return diff;
}

void printArray(double[] array)
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

double []Array = GenerateRandomArray(4, 1, 10);
printArray(Array);
Console.WriteLine();

double Maxx = MaxElementArray (Array);
double Min = MinElementArray (Array);
double DiffOfElements = getDiffMinOfMaxElementInArray(Maxx, Min);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {DiffOfElements}");