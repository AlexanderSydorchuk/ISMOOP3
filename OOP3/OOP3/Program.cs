using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction drib = new Fraction(1,3);
            Fraction drib2 = new Fraction(7);
            Fraction drib3 = new Fraction("5/7");

            Console.WriteLine($"{drib} > {drib2}: {drib > drib2}");
            Console.WriteLine($"{drib} < {drib2}: {drib < drib2}");
            Console.WriteLine($"{drib} = {drib3}: {drib == drib3}");
            Console.WriteLine($"{drib} != {drib3}: {drib != drib3}");

            Console.WriteLine();

            Fraction drib4 = new Fraction();
            Fraction drib5 = new Fraction();
            Fraction drib7 = new Fraction();
            Fraction drib8 = new Fraction();
            Fraction drib9 = new Fraction();
            Fraction drib10 = new Fraction();

            drib4 = drib2 + drib3;
            drib5 = drib2 - drib3;
            drib7 = drib + drib3;
            drib8 = drib * drib3;
            drib9 = drib / drib3;
            drib10 = -drib3;

            Console.WriteLine($"{drib2} + {drib3} = {drib4}");
            Console.WriteLine($"{drib2} - {drib3} = {drib5}");
            Console.WriteLine($"{drib} + {drib3} = {drib7}");
            Console.WriteLine($"{drib} * {drib3} = {drib8}");
            Console.WriteLine($"{drib} / {drib3} = {drib9}");
            Console.WriteLine($"-drib3 = {drib10}");

            Console.WriteLine();

            Fraction drib6 = new Fraction("26/78");
            Console.WriteLine($"Скоротити дрiб: {drib6}");
            drib6.Normalize();
            Console.WriteLine($"{drib6}");

        }
    }
}
