/*Программа, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

В этом варианте не используем дополнительную переменную и числа идут по убыванию.
*/

Console.Clear();
Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Вот все четные числа в диапазоне от " + number + " до 1" );
Console.WriteLine();

while (number > 1)
    {
        if (number % 2 ==0) Console.Write(number + "  " );
        number--;
    }