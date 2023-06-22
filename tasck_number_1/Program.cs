// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if(a == b * b){
    Console.Write("Да");
}
else{
    Console.Write("Нет");
}


