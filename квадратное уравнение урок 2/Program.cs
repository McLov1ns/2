using System;
Console.WriteLine();
Double a;
Double b;
Double c;
Double D;
Double x1;
Double x2;
Console.WriteLine("введите а:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите c:");
c = Convert.ToDouble(Console.ReadLine());
 D=(b*b) - 4 * a * c;
if (D >= 0) 
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("x1={0}\n x2={1}", x1, x2);
    Console.ReadKey(); }

    else
{ 
    Console.WriteLine("Нет решений");
    Console.ReadKey();

}