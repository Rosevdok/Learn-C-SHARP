// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите целые числа через пробел: ");
string imput = Console.ReadLine();

int[] ConvertIntArrey(string text, char separ)
{
    string[] imput = text.Split(separ);
    int[] num = new int[imput.Length];
    for (int i = 0; i < num.Length; i++)
    {
        int temp;
        string value = imput[i];
        if (int.TryParse(value, out temp)) { num[i] = temp; }
    }
    return num;
}

int[] output = ConvertIntArrey(imput, ' ');

int sum = 0;
for (int i = 0; i < output.Length; i++)
{
    sum += output[i] > 0 ? 1 : 0;
}

Console.WriteLine($"Количество чисел больше 0 в списке: {sum}.");