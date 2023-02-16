// может ли существовать треугольник со сторонами равными заданными пользователем



Console.Clear();
Console.WriteLine("Введите стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a+b>c && b+c>a && a+c>b)
Console.WriteLine("yes");
else
Console.WriteLine("no");