// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

double NaturalNumber()
{
    return Convert.ToDouble(Console.ReadLine());
}

void Recurs(int num)
{
    Console.Write(num);
    if (num != 1)
    {
        Console.Write(", ");
    }
    if (num > 1)
    {
        Recurs(num-1);
    }    
}
Console.WriteLine("Введите натуральное число:");
double num = NaturalNumber();
Console.WriteLine();
Console.Write("");
Recurs((int)num);
