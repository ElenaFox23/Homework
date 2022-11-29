Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n >= 100) n/= 10;
int k = n % 10;
Console.WriteLine(k);