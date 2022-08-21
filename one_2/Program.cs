// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Присвойте значение числу A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Присвойте значение числу B");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
if(numberA>max) max = numberA;
if(numberB>max) max = numberB;
Console.Write("Большее число = ");
Console.WriteLine(max);

int min = numberA;
if(numberA<min) min = numberA;
if(numberB<min) min = numberB;
Console.Write("Меньшее число = ");
Console.WriteLine(min);