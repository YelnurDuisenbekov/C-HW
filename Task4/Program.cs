Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 > number2)
{
    Console.WriteLine("Максимальное значение: " + number1);
    Console.WriteLine("Минимальное значение: " + number2);
}
else
{
    Console.WriteLine("Максимальное значение: " + number2);
    Console.WriteLine("Минимальное значение: " + number1);
}