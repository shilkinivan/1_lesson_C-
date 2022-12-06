Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
    Console.WriteLine(num1);
    }
    else
    {
    Console.WriteLine(num3);
    }
}
else 
{
    if (num2 > num3)
    {
    Console.WriteLine(num2);
    }
    else
    {
    Console.WriteLine(num3);
    }
}