/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29   */

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);
System.Console.WriteLine( $"M = {m}; N = {n}");
System.Console.WriteLine();
System.Console.WriteLine(Ackermann(m,n));


int Ackermann (int a, int b)
{
    if (a==0)
    {
        return (b+1);
    }
    if ((a != 0) && (b == 0))
    {  
        return Ackermann(a - 1, 1);
    }
    else 
    {
        return Ackermann(a - 1, Ackermann(a, b - 1));
    }

}
