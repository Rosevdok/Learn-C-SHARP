// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());
int num = 0;

void FillArray(int[] array)
{
    for (int i = 0; i < number; i++)
    {
        array[i] =new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int PozitivNam(int[] arr)
{
    foreach (int value in arr)
    {
        if (value % 2 == 0) num++;
    }
    return num; 
}

int[] array = new int[number];
FillArray(array);
PrintArray(array);
number = PozitivNam(array);
Console.WriteLine();
Console.Write($" {number} "+"чётных элементов в массиве.");