Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0) n = n * -1;
else
if (n < 100) 
    Console.WriteLine("Нет третьей цифры ");
else
while (n > 1000)
    n /=10;

Console.WriteLine(n % 10);