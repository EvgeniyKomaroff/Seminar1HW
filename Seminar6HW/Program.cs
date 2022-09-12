//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int Positive(int length)
{
    int[] array = new int [length];
    int count = 0;
    for(int i = 0; i < length; i++)
    {
        Console.Write($"Ввведите число номер {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
          {
            count++;
          }
    }
    return (count); 
}

Console.Write("Укажите колличество вводимых чисел : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колличество положительных чисел: " + Positive(n));


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// Точка пересечения по х : k1*x + b1 = k2*x + b2 ; k1*x-k2*x = b2 - b1 ; x=(b2-b1)/(k1-k2)

void Point(double n1, double n2, double n3 , double n4)
{
      double x; double y; 
      x = (n3 - n2) / (n2 - n4) ;
      y = (n2*x+n3) ;  
      Console.WriteLine($"({x};{y})");
}

Console.Write("Ввведите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
 
Point(b1, k1, b2, k2);

