Console.Clear();
Console.Write("Введите 1-е число: ");
int a = 
Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число ");
int b = 
Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число ");
int c = 
Convert.ToInt32(Console.ReadLine());

// int max = 0;
// if ((a > b)&&(a > c))
// max = a;
// else if ((b > a)&&(b > c))
// max = b;
// if ((c > a)&&(c > b))
// max = c;
// Console.WriteLine(max);

int max = new[] { a, b, c }.Max();
Console.WriteLine(max);