// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число, до которого нужно проверить четные числа от 1");
int N = Convert.ToInt32(Console.ReadLine());
for (int number = 1; number <= N; number++)
if (number%2==0)
Console.WriteLine(number);