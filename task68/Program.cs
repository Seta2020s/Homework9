// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetAckermann(int m, int n)
{
    if (m == 0)
        return n + 1;

    if (n == 0)
        return GetAckermann(m - 1, 1);

    return GetAckermann(m - 1, GetAckermann(m, n - 1));
}

void PrintAckermann(int m, int n)
{
    Console.WriteLine($"A({m}, {n}) = {GetAckermann(m, n)}");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите значение m: ");
int n = GetInput("Введите значение n: ");

PrintAckermann(m, n);