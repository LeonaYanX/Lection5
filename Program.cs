//Задача 1: Вычеслить Факториал от натурального числа Н. Ели 1! и 0! равно 1.
int FactorialN(int N) 
{
    int Factorial = 0;
    if (N <=1) 
    {
        Factorial = 1;
        return Factorial;
    }
    return Factorial= N * FactorialN(N - 1);
}
Console.WriteLine(FactorialN(3));
Console.ReadLine();
