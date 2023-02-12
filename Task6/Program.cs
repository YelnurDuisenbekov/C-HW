// четное, не четное
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
if (number1 % 2 == 0)
{
    Console.Write("Четное");
}
else
{
    Console.Write("Не четное");
}