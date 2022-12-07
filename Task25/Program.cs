Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int n = a;
for (int i = 1; i < b; i++)
n = n * a;
Console.WriteLine($"{a} в степени {b} = " + n);