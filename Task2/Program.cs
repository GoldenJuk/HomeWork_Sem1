/*Программа, которая на вход принимает
два числа и выдаёт, какое число большее, 
а какое меньшее.
*/

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (number1 > number2) Console.WriteLine("Первое число больше второго");

if (number1 < number2) Console.WriteLine("Второе число больше первого");

if (number1 == number2)Console.WriteLine("Введенные числа одинаковые");