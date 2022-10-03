void printNutNums(int num)
{
    
    if (num <= 0)
    {
        Console.Write($"Число {num} не натуральное!\nВведите натуральное число больше 1: ");
        printNutNums(Convert.ToInt32(Console.ReadLine()));
        return; 
    }
    if (num - 1 == 0)
    {
        Console.Write($"{num}");
    }
    else
    {
        Console.Write($"{num}, ");
        printNutNums(num-1);
    }
    
}

Console.Write("Введите натуральное число больше 1: ");
try
    {
        printNutNums(Convert.ToInt32(Console.ReadLine()));
    }
catch
    {
       Console.Write($"Введено не натуральное число!\nВведите натуральное число больше 1: ");
       printNutNums(Convert.ToInt32(Console.ReadLine()));
    }