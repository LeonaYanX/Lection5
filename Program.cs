//Задача 1: Вычеслить Факториал от натурального числа Н. Ели 1! и 0! равно 1.
int FactorialN(int N) 
{
    
    int Factorial = 0;
    if (N <=1) 
    {
        Console.WriteLine($"Stoping reqursion N = {N}");
        Factorial = 1;
        Console.WriteLine($"Factorial N = {Factorial}");
        return Factorial;
    }
    Console.WriteLine($"N is = {N}");
    Console.WriteLine($"Factorial N = {Factorial}");
    Factorial = N * FactorialN(N - 1);
    Console.WriteLine($"Unwinding N ={N}");
    Console.WriteLine($" UNWINDING Factorial N = {Factorial}");
    return Factorial;
}
Console.WriteLine(FactorialN(5));

Console.ReadLine();


