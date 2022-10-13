// Задача 69. Напишите программу, которая принимает на вход два числа А и В, и возводит число А в степень В 
// с помощью рекурсии.
// А = 3; В = 5; -> 243 
// A = 2, B = 3 -> 8

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

int NumberExponent(int a, int b)
{
    if (b == 1) return a;
    else return a * NumberExponent(a, b - 1);
}

int result = NumberExponent(A, B);
Console.WriteLine(result);