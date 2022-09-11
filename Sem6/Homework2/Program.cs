// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine($"\nЗадача 43.  Найти точку пересечения двух прямых \n");

double[,] ratio = new double[2, 2];
double[] point = new double[2];

void InputRatio()       // Создание массива с вводимыми переменными
{
  for (int i = 0; i < ratio.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < ratio.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      ratio[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Calc(double[,] ratio)      // Вычисление точек пересечени
{
  point[0] = (ratio[1,1] - ratio[0,1]) / (ratio[0,0] - ratio[1,0]);
  point[1] = point[0] * ratio[0,0] + ratio[0,1];
  return point;
}

void OutputResalt(double[,] ratio)      // Определение пересечения прямых
{
  if (ratio[0,0] == ratio[1,0] && ratio[0,1] == ratio[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (ratio[0,0] == ratio[1,0] && ratio[0,1] != ratio[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Calc(ratio);
    Console.Write($"\nТочка пересечения прямых: ({point[0]}, {point[1]})");
  }
}

InputRatio();
OutputResalt(ratio);