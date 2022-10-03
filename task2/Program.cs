void getSumMN(int M, int N)
{
    int sum = 0;
    for (int i = M; i <= N; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна {sum}");
}

int getIntValue(string val, char MNtype)
{
    if (int.TryParse(val, out int value))
    {
        return getPosValue(value, MNtype);
    }
    else
    {
        Console.Write($"Необходимо ввести натуральное число! Введите {MNtype}: ");
        return getIntValue(Console.ReadLine(), MNtype);
    }
}

int getPosValue(int PosValue, char MNtype)
{
    if (PosValue < 1)
    {
        Console.Write($"Необходимо ввести натуральное число! Введите {MNtype}: ");
        return getIntValue(Console.ReadLine(), MNtype);
    }
    else
    {
        return PosValue;
    }
}

int getEndValue(int startVal, int endVal)
{
    if(startVal > endVal)
    {
        Console.Write($"N должно быть меньше M (Введеное значение M = {startVal})! Введите N: ");
        return getIntValue(Console.ReadLine(), 'N');
    }
    else
    {
        return endVal;
    }

}

Console.WriteLine("M - начало промежутка натуральных чисел\nN - конец промежутка натуральных чисел");
Console.Write("Введите M: ");
int m = getIntValue(Console.ReadLine(), 'M');
Console.Write("Введите N: ");
int n = getEndValue(m, getIntValue(Console.ReadLine(), 'N'));
getSumMN(m,n);










