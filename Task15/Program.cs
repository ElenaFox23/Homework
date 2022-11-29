Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
Console.Write("Вы ошиблись!\nВведите день недели: ");
n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
Console.Write("Выходной день ");
else
Console.Write("Рабочий день");
 