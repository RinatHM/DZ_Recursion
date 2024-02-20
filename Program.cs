//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
void RangeOfDigit(int n, int m )
{
    if (n >= m)
    {
        Console.WriteLine(n);
        return;
    }
   
    RangeOfDigit(n + 1, m);
    Console.WriteLine(n);
}
//int n = 1;
RangeOfDigit(1, 14);
