// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());

void FillArray(double[] array)
{
    for (int i = 0; i < number; i++)
    {
        Random rnd = new Random();
        double min = -10.34;
        double max = 53.44;
        array[i] = rnd.NextDouble() * (min + max) - min;
        array[i] = Math.Round(array[i], 1);
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double DiffMaxMin(double[] arr)
{
    double minNum = arr[0];
    double maxNum = arr[0];
    double differ = 0;
    foreach (double val in arr)
    {
       if (val > maxNum ) maxNum = val;
       
       if (val < minNum) minNum = val;
    }
    differ = maxNum - minNum;
    differ = Math.Round(differ, 1);
    return differ; 
}

double[] array = new double[number];
FillArray(array);
PrintArray(array);
double differMaxMin = DiffMaxMin(array);
Console.WriteLine();
Console.Write($" {differMaxMin} "+"разница между минимальным и максимальным числами в массиве.");