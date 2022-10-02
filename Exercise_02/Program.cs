/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = GetArray(10, -50, 50);
Console.WriteLine(String.Join(" ", array));

int res = NechetPos(array);
Console.WriteLine($"Сумма нечётных элементов массива = {res}");


int[] GetArray(int size, int minValue, int maxValue)

{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}


int NechetPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}