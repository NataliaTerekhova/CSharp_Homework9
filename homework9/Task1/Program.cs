/* Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"   */

int m = new Random().Next(1,6);
int n = new Random().Next(5,10);
System.Console.WriteLine( $"M = {m}; N = {n}");
System.Console.WriteLine();
System.Console.WriteLine("Числа в промежутке от M до N:");
System.Console.WriteLine(PrintNumbers(m,n));

string PrintNumbers(int start, int end)
{
    if (start==end)
    {
        return start.ToString();
    }
    return (start + " " + PrintNumbers(start+1, end));
}

