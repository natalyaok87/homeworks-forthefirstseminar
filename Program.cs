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
    
}
else
{
    max = numberB;
    min = numberA;
}
Console.WriteLine("max =" + max);
Console.WriteLine("min =" + min);