// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координата точки пересечения: [{(b2-b1)/(k1-k2)};{k1*((b2-b1)/(k1-k2))+b1}]");

// double x1 = (-1000;1000); double x2 = (-1000;1000);
// double y2=k1*x1+b1; double y2=k2*x2+b2;
// if (x1 == x2 && y1 ==y2)
// {Console.WriteLine($"{x1},{y1}");}

