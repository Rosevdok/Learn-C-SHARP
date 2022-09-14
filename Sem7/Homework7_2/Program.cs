// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//17 -> такого числа в массиве нет

Console.Write("введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[row, col];

Console.Write("введите число для поиска: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

FillArrayNumbers(numbers);
PrintArray(numbers);
SeekNumber(numbers);
PrintSeekNumber(numbers);

void FillArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Введите элемент массива {i + j}: ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void SeekNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num) sum += 1;
        }
    }
}

void PrintSeekNumber(int[,] array)
{
    if (sum != 0)
    {
        
    }
    else
    {
        Console.Write($"Числа {num} в массиве нет.");
    }
}