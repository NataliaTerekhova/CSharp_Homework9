/*Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30   */

int m = new Random().Next(1,6);
int n = new Random().Next(5,10);
System.Console.WriteLine( $"M = {m}; N = {n}");
System.Console.WriteLine();
System.Console.WriteLine(GetSum (m,n));


int GetSum (int start, int end)
{
    if (start==end)
    {
        return start;
    }
    return start + GetSum(start+1, end);
}
