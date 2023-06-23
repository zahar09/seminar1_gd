// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int i;
if(number >=0 ){
    i = number * -1;
}
else{
    i= number;
    number = number * -1;
}


while (i < number+1)
{
    Console.Write(i);
    Console.Write(" ");
    i++;
}
