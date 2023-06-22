Console.WriteLine("Введите число:");
int m = int.Parse(Console.ReadLine());
if (m == 1)
{
    Console.WriteLine("Понедельник");
} 
else if (m == 2)
{
    Console.WriteLine("Вторник");
} 
else if (m == 3)
{
    Console.WriteLine("Среда");
} 
else if (m == 4)
{
    Console.WriteLine("Четверг");
} 
else if (m == 5)
{
    Console.WriteLine("Пятница");
} 
else if (m == 6)
{
    Console.WriteLine("Суббота");
} 
else if (m == 7)
{
    Console.WriteLine("Воскресенье");
} 
else
{
    Console.WriteLine("Такого дня недели нет");
}
