// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

string ShowNumbers(int count, int num)
{
    if(count <= num) 
    {
        return $"{count}, " + ShowNumbers(count+1, num);
    }
    else return String.Empty;
}

ShowNumbers(1, N);
Console.WriteLine(ShowNumbers(1, N));





Console.WriteLine();
