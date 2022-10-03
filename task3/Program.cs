int getIntValue(string val, char MNtype)
{
    if (int.TryParse(val, out int value))
    {
        return getPosValue(value, MNtype);
    }
    else
    {
        Console.Write($"Необходимо ввести целое положительное число! Введите {MNtype}: ");
        return getIntValue(Console.ReadLine(), MNtype);
    }
}

int getPosValue(int PosValue, char MNtype)
{
    if (PosValue < 0)
    {
        Console.Write($"Необходимо ввести целое положительное число! Введите {MNtype}: ");
        return getIntValue(Console.ReadLine(), MNtype);
    }
    else
    {
        return PosValue;
    }
}

int getCorrectValue(char MNtype)
{
    Console.Write($"Введите {MNtype}: ");
    return getIntValue(Console.ReadLine(), MNtype);
}

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return AkkermanFunc(m - 1, 1);
    }
    else 
    {
        return AkkermanFunc(m - 1, AkkermanFunc(m, n -1));
    }
}




Console.WriteLine("Переменые функции Аккермана: M и N - целые положительные числа");
Console.WriteLine(AkkermanFunc(getCorrectValue('M'), getCorrectValue('N')));