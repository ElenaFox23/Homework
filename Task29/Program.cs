
Console.Clear();
int[]a = new int[8];
Console.Write("Введите массив чисел ");
for(int i = 0; i < 8; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < 8; i++)
Console.Write($"{a[i]} " );