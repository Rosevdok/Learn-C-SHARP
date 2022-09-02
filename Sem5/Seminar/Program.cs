//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].

//Найдите сумму отрицательных и положительных элементов массива.

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

void PrintArray(int[] array)
{
Console.WriteLine("Вывод массива: ");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine("");
}

//___________________
//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

void Zadacha18()
{
int size = new Random().Next(4, 10);
int[] array = new int[size];
FillArray(array, -99, 99);
PrintArray(array);
Reverse(array);
PrintArray(array);
}

void Reverse (int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] *= -1;
}
}

void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
finishNumber++;
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = random.Next(startNumber, finishNumber);
}
}

void PrintArray (int[] array)
{
Console.WriteLine("Вывод массива: ");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine("");
}
int[] array = GetArray(12, -9, 9);
PrintArray(array);

int positiveSum = 0;
int negativeSum = 0;

foreach (int value in array)
{
positiveSum += value > 0 ? value : 0;
negativeSum += value < 0 ? value : 0;
}

Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");
//___________________

void Zadacha19()
{
int size = new Random().Next(4, 10);
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Reverse (array);
PrintArray(array);
}

void Reverse (int [] array)
{
int size = array.Length;
for (int i = 0; i < size; i++)
{
array[i] *= -1;
}

}


void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
finishNumber++;
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = random.Next(startNumber, finishNumber);
}
}

void PrintArray(int[] array)
{
Console.WriteLine("Вывод массива:");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine("");
}

Zadacha19();
//_______________________
//Функция проверяет наличие числа в массиве.

void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(1, 11);
index++;
}
}

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
Console.Write(col[position] + " ");
position++;
}
}

int IndexOf(int[] collection, int find)
{
int count = collection.Length;
int position = -1;
int index = 0;
while (index < count)
{
if (collection[index] == find)
{
position = index;
break;
}
index++;
}
if (position == -1) Console.WriteLine("Такого элемента нет");
else Console.WriteLine("Индекс совпавшего элемента = " + position);
return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 2);
//_________________________
//Второй вариант решения

array = fill_array(12, -9, 9);
print_array(array);

string search(int[] array_num, int num)
{
for (int i = 0; i < array_num.Length; i++)
{
if (array_num[i] == num)
{
return "Число есть";
}
}
return"Числа нет";
}

Console.WriteLine(search(array, 3));
//______________________________
//Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(1, 100);
index++;
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
int Counter(int[] array)
{
int sum = 0;
foreach (int value in array)
{
if (value > 9 && value < 100)
{
sum = sum + 1;
}
}
return sum;
}

int[] array = new int[123];
FillArray (array);
PrintArray(array);
Counter(array);
int res = Counter(array);
Console.WriteLine();
Console.WriteLine(res);


