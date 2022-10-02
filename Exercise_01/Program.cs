/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int sum = HowMany(array);
Console.WriteLine($"Количество чётных чисел в массиве = {sum}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return arr;
}


int HowMany(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}