//Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее
//a=5, b=7 ->max =7

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console. WriteLine($"{number1} - Максимальное число, {number2} - Минимальное число");
}
else
{
    Console. WriteLine($"{number2} - Максимальное число, {number1} - Минимальное число");
}