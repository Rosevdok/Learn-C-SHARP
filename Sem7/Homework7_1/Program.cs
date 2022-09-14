// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillNewArray(array);
PrintNewArray(array);

void FillNewArray(int[,] newArray)       //Заполнение массива
{
    for (int i = 0; i <= newArray.GetLength(0); i++)
    {
        for (int j = 0; j <= newArray.GetLength(1); j++)
        {
            Console.Write($"Введите элемент массива{ i+j}: ");
            newArray[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

void PrintNewArray(int[,] newArray)      // Печать массива
{
    for (int i = 0; i <= newArray.GetLength(0); i++)
    {
        for (int j = 0; j <= newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
    Console.WriteLine();
    }
}