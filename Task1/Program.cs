// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// *VAR!*
// Console.WriteLine("Insert number A: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Insert number B: ");
// int B =int.Parse(Console.ReadLine());
//  Console.WriteLine(Math.Pow(A,B));

//Var2
void PrintPower(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    Console.WriteLine(result);
}
Console.WriteLine("Insert number A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number B: ");
int B =int.Parse(Console.ReadLine());

PrintPower(A,B);
 Console.WriteLine("Is  " + A + " to the " + B + " power ");