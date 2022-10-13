// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

 int SumOfNumbers(int n)
{
    if (n == 0) return 0;
    else return (n%10 + SumOfNumbers(n/10));
}

Console.WriteLine(SumOfNumbers(N));