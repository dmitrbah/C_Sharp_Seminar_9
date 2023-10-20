Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigits(number));

int SumOfDigits(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumOfDigits(num / 10);
}