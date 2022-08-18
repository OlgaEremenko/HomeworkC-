// Напишите программу, которая на вход принимает число N, 
// а на выходе показывает все четные числа  от 1 до N
// 5-> 2,4
// 8> 2,4,6,8,

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;

while (counter <= number)
{
    if (counter % 2 == 0)
        Console.WriteLine(counter);
    counter = counter+1;
}
 // увы, так ничего и не заработало..

  
