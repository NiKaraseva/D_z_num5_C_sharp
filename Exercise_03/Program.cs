/* Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] array = GetArray(10, 10, 70);
Console.WriteLine(String.Join(" ", array));

double result = GetMinMax(array);
Console.WriteLine($"Разница между max и min вещественными числами = {Math.Round(result, 2)}");


double[] GetArray(int size, double minValue, double maxValue)
{
    double[] arr = new double[size];
    for(int i = 0; i < size; i++)
    {
        double x = new Random().NextDouble();
        arr[i] = Math.Round(x * (70 - 10) + 10, 2); // Эта формула приводит число к отрезку от A до B  - умножение на длину, чтоб не выйти за В, прибавляем А, чтоб не остаться левее А
    }
    return arr;
}


double GetMinMax(double[] array)
{
    double min = array[0];
    double max = array[0]; 
    double subtr = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }

        else if(array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Минимальное значение массива = {min}");
    Console.WriteLine($"Максимальное значение массива = {max}");
    subtr = max - min;
    return subtr;
}

