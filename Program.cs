задача 2
int numberA = new Random() .Next(-10, 11);
Console.WriteLine(numberA);
int numberB = new Random() .Next(-10, 11);
Console.WriteLine(numberB);
int max = 0;
int min = 0;

if (numberA > numberB)
{
    max = numberA;
    min = numberB;


задача 4

int numberA = new Random() .Next(-15, 11);
Console.Write($"{numberA, 3} ");
int numberB = new Random() .Next(-15, 11);
Console.Write($"{numberB, 3} ");
int numberC = new Random() .Next(-15, 11);
Console.WriteLine($"{numberC, 3} ");
int max = 0;

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        max = numberA;
    }
    else
    {
        max = numberC;
    }
}
else
{
    if (numberB > numberC)
    {
        max = numberB;
    }
    else
    {
        max = numberC;
    }

}
Console.WriteLine(max);

задача 8

int N = new Random() .Next(1,20);
int M = 1;
Console.WriteLine(N);
while (M < N)
{
    if (M % 2 ==0)
    Console.WriteLine($"{M,2} ");
    M = M + 1;
}






    
}
else
{
    max = numberB;
    min = numberA;
}
Console.WriteLine("max =" + max);
Console.WriteLine("min =" + min);