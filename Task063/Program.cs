Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

PrintNaturalNumbers(number);

void PrintNaturalNumbers(int num)
{
    if (num == 0) return;
    PrintNaturalNumbers(num - 1);
    Console.Write($"{num} ");
}
