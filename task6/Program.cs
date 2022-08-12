// Напишите программу, которая на вход принимает число и выдает, является
// ли число четным (делится ли оно на 2 без остатока)
// 4-> да
// -3> нет
// 7-> нет

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2==0) {
     Console.WriteLine($"{number} = Четное");
} else {
     Console.WriteLine($"{number} = Нечетное");
} 