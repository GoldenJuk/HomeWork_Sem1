/* Программ, которая на вход принимает число и 
выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
*/

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (number % 2 ==0) Console.WriteLine("Введенное число является четным");

else
{
    Console.WriteLine("Введенное число не является четным");
}
Console.WriteLine("");