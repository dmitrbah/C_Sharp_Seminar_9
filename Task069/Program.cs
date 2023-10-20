Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)
{
    Console.WriteLine(1/(double)PowerAtoB(numberA,-numberB));
}

if (numberB > 0)
{
    Console.WriteLine(PowerAtoB(numberA,numberB));
}

int PowerAtoB(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * PowerAtoB(numA, numB - 1);
}

