// 1 тип методов
void Metod1()   // Метод № 1.
{
Console.WriteLine("Автор .....");
}
//Metod1(); // Вызов метода № 1

void Metod(string msg);
{
    Console.WriteLine(msg);
}
//Metod2("Текстовое сообщение.");

void Metod21(string msg, int count);    //Метод № 2
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Metod21("Текст сообщения", 4);  // Вызов метода №2 первый способ
Metod21(msg: "Текст сообщения", count: 4);   // Вызов метода №2 второй способ. Именованные переменные.
Metod21(count: 4, msg: "Текст сообщения");   // Вызов метода №2 второй способ. Именованные переменные можно менять местами. 

int Metod3();   //Метод № 3
{
    return DateTime.Now.Year;    
}

int year = Metod3(); // Вызов метода № 3 через переменную.
Console.WriteLine(year);

string Metod4(int count, string text)   // Метод № 4
{
    int i = 0;
    string resalt = String.Empty;
    while(i < count)
    {
        resalt = resalt + text;
        i++;
    }
    return resalt;
}

string rez = Metod4(10, "Новый");   //Вызов метода 4
Console.WriteLine(rez);

string Metod4(int count, string text)   // Метод № 4 с циклом for
{
    string resalt = String.Empty;
    for (int i = 0; i < count; i++)
    {
        resalt = resalt + text;
    }
    return resalt;
}

// Выводтаблицы умножения через цикл for
for (int i = 2; i <= 10; int++); 
{
    for (int j = 2; j <= 10; j++);
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

// Задача с заменой символов в тексте.

string Replace(string text, char oldValue, char newValue)
{
    string resalt = string.Empty;
    int langth = text.Langth;
    for (int i=0; i < langth; i++)
    {
        if(text[i] == oldValue) resalt = resalt + $"{newValue}";
        else resalt = resalt + $"{text[i]}";
    }
    return resalt;
}
string newText = Replace(" ", "|");
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace("k", "K");
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace("C", "c");
Console.WriteLine(newText);
Console.WriteLine();


// Сортировка массива методом МиниМакса
int[] arr = {1,5,4,3,2,6,7,1,1};   // Определяем массив

void PrintArray(int[] array);   // Метод перебирает массив
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array);    // Метод сортирует массив.
{
    for(int i = 0; i < arrayLength - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;

        }
        temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);    // Вывод метода.
SelectionSort(arr); // Вывод метода.
PrintArray(arr);    // Вывод метода.