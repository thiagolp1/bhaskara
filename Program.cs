﻿double a, b, c, x1, x2, delta;

Console.Write("-- Equação do segundo grau --");

Console.ReadKey();
Console.Clear();

Console.Write("(a): ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("(b): ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("(c): ");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (a == 0)
{
    Console.WriteLine("Não é uma equação de segundo grau!");
}
else
{
     delta = b * b - 4 * a * c;
    if (delta < 0)
     {
         Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raízes reais!");
     }
     else
     {
         x1 = (-b + Math.Sqrt(delta)) / (2 * a);
         x2 = (-b - Math.Sqrt(delta)) / (2 * a);

         Console.WriteLine($"x1 = {x1:N2} e x2 = {x2:N2}");
     }
}