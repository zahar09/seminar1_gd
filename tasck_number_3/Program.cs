// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int i = -number;
while (i < number+1)
{
    Console.Write(i);
    Console.Write(" ");
    i++;
}
