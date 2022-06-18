// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberSum(int A)
{
    int sum = 0;
    while ( A != 0)
    {
        sum += A % 10;
        A /= 10;
    }
    return sum;
}

Console.WriteLine("Insert number: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Sum of digits in the number "+A+" is "+NumberSum(A));