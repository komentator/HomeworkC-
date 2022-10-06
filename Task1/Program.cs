//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите превое число ->");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ->");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine($"{num1} больше {num2}");
}
if (num2>num1)
{
    Console.WriteLine($"{num2} больше {num1}");
}
if (num2==num1)
{
    Console.WriteLine($"{num2} равен {num1}");
}