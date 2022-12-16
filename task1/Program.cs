// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Ведите числа m и n ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
SumElements(m,n);
Console.WriteLine(SumElements(m-1,n));

int SumElements(int m,int n)
{
	int res=m;
    if ( m==n )
           return 0;
    m++;
    res=m+SumElements(m,n);    
    return res;
}