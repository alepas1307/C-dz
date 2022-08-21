// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Присвойте значение числу A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Присвойте значение числу B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Присвойте значение числу C");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;
if(numberA>max) max = numberA;
if(numberB>max) max = numberB;
if(numberC>max) max = numberC;
Console.Write("Большее число = ");
Console.WriteLine(max);