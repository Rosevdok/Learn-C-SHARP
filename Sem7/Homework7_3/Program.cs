// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[row, col];

int[] averegCol = new int[col];


FillArrayNumbers(numbers);
PrintArray(numbers);
AveregColumns(numbers);
PrintAveregCol(averegCol);

// Заполнение массива
void FillArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

//Печать массива
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

// Нахождение среднего числа столбца
void AveregColumns(int[,] array)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        int aver = sum / array.GetLength(0);
        averegCol[j] = aver;
        sum = 0;
    }
}

// Печать массива средних чисел столбцов
void PrintAveregCol(int[] averCol)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < averCol.GetLength(0); i++)
    {
        Console.Write($"{averCol[i]}" + "  ");
    }
}