/*Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/


void RangeOfDigit(int n)
{
    int[] massiv = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    if (n == massiv.Length)
    {
        //Console.WriteLine(massiv[n-1]);
        return;
    }
    RangeOfDigit(n + 1);
    Console.WriteLine(massiv[n]);
}
RangeOfDigit(0);

