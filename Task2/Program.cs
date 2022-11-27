Console.Clear();
Console.Write("Введите 1-е число: ");
int a = 
Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число ");
int b = 
Convert.ToInt32(Console.ReadLine());
if (a > b)
{ 
 Console.WriteLine($"Максимальное число {a}");
 Console.WriteLine($"Минимальное число {b}");
}
else
{ 
Console.WriteLine($"Максимальное число {b}");
Console.WriteLine($"Минимальное число {a}");
}    
