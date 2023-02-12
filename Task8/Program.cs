// все четные до n
Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
int i;
for (i =1; i < number1; i++)
{
    if (i % 2 == 0)
    {
       Console.Write(i);
    }
}