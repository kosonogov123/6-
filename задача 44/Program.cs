﻿// вывести первые N чисел фибоначи без рекурсии
Console.WriteLine("Введите число фибоначи: ");
int n = Convert.ToInt32(Console.ReadLine());


int a0=0;
int a1 =1;
for (int i =0; i<n; i++)
{Console.Write($"{a0} ");
   
   int x = a0+a1;
   a0=a1;
   a1=x;}
   
