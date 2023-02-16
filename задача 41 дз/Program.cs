// пользователь вводит М чисел, сколько из них больше 0
Console.Clear();
Console.WriteLine("введите количество вводимых чисел:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива: ");

int[] array =new int[n];

for (int i=0; i<n;i++)
{array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Полученный массив : [{string.Join(", ",array)}]");
int b= 0;
for (int i=0; i<n;i++)
{if (array[i]>0)
{b++;}}
Console.WriteLine($"{b} - числа больше 0");