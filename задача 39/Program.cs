// замена первого элемента на последний, и остальных между собой
void Im(int[] array)
{
    for (int i=0; i<array.Length; i++)
    array[i] = new Random().Next(1,10);
}
void In(int[] array)
{
    for (int i=0; i<array.Length/2;i++)
    {int temp = array[i];
    array[i]= array[array.Length-i-1];
    array[array.Length-i-1] = temp;}

}
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n =Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Im(array);
Console.WriteLine($"начальный массив: [{string.Join(", ",array)}]");
In(array);
Console.WriteLine($"конечный массив: [{string.Join(", ",array)}]");
    
