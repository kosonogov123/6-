// программа преобразовывающая десятичное число в двоичное
// Console.Clear();
Console.WriteLine(" Введите десятичное число:");
int a = Convert.ToInt32(Console.ReadLine());
    int result = 0;
int d =1;
for (int i = 0; a>0 ;i++) 
{ int c = a%2;
 
    int b =(c)*d;

    result = result+b;
    
   Console.WriteLine($"разряды: {c} ");
   a= a/2;
   d=d*10;
}
   

   Console.WriteLine($"двоичное значение: {result} ");