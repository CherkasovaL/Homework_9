// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputInt("M=");
int n = InputInt("N=");
Console.WriteLine($"{Count(m, n)}");

int InputInt(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "0");
}

int Count(int m, int n)
{
    if (m == n)
        return n;
    return n + Count(m, n - 1);
}
