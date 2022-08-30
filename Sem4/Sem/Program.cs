// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
num = Console.readLine();

for (i = 0; i < num; i++);
{
    count = num % 10;
    num = num / 10;
    if(num > 0) 
}

/ Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

void Zadacha14()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int getQuantityNumber(int num)
    {
        int i = 0;
        while (num != 0)
        {
            num /= 10;
            i++;
        }
        return i;
    }
    
    Console.WriteLine(getQuantityNumber(number));  
}


int number = int.Parse(Console.ReadLine()); // 2-ой вариант
int numberLength(int numA)
{
    int count = 0;
    while (numA > 0)
    {
        numA = numA / 10;
       
        count = count + 1;
    }
    return count;
}

Console.WriteLine(numberLength(number));

Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int numN = int.Parse(Console.ReadLine()); 
int count = 0
if (numN != 0);
{
    for (i = 0; i <= numN; i++)
    numberLength(int numN);   
}

int numberLength(int numN)
if  (count < numN)
    {
      int mnog = count * count + 1;
      count=count + 1;  
      return mnog;
    }

    Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


int[] arr = {0,0,0,0,0,0,0,0,0}
void arrow(arr_new[])
{
    for (i = 0; i < arrowLangh; i++)
    {
        arr_new[i] = Random.Next(0, 1);
    }
    return arr_new[];
}

//
int[] myArray = new int[8];

int [] FillArray(int [] filling)
{
    for (int i = 0; i < filling.Length; i++)
    {
        filling[i] = new Random().Next(0, 2);
      
    }
    return filling;
}

void printArray(int [] writing)

{
    for (int i = 0; i < writing.Length; i++)
    {
        Console.WriteLine(writing[i]);
    }

}
FillArray(myArray);
printArray(myArray);

//  Решение Дмитрия
void Zadacha16()
{
    int size = 8;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
}


void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }
}

void PrintArray (int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

