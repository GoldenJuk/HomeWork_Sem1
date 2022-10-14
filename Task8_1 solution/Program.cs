/*Программа, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

В этом варианте используем дополнительную переменную и числа идут по возрастанию.
*/

Console.Clear();
Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int index = 1;

Console.WriteLine();
Console.WriteLine($"Вот все четные числа в диапазоне от 1 до "  +  number);
Console.WriteLine();

while (number >= index)
    {
        if (index % 2 ==0) Console.Write(index + "  " );
        index++;
    }