// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.

Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {akkerman(m, n)}");

int InputInt(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "0");
}

int akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return akkerman(m - 1, 1);
    else
        return akkerman(m - 1, akkerman(m, n - 1));
}
