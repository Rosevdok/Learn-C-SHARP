// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());


void FillArray(int[] array)
{
    for (int i = 0; i < number; i++)
    {
        array[i] =new Random().Next(-99, 100);
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

int SumNegativNam(int[] arr)
{
    int count = 1;
    int temp = 0;
    int sum = 0;
    while (count < number)
    {
        temp = arr[count];
        sum += temp;
        count += 2;
    }
    return sum; 
}

int[] array = new int[number];
FillArray(array);
PrintArray(array);
int sumNegNam = SumNegativNam(array);
Console.WriteLine();
Console.Write($" {sumNegNam} "+"сумма элементов на нечётных местах в массиве.");