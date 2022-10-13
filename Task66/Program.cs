// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int m, int n)
{
    if (m == n) return m;
    else return m + SumOfNumbers(m + 1, n);
}

Console.Write($"Сумма натуральных элементов в диапазоне от {M} до {N} равна ");
Console.WriteLine(SumOfNumbers(M, N));