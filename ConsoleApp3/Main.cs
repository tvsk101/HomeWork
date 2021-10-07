using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите числитель первой дроби: ");
            int Numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель первой дроби: ");
            int Denominator1 = Convert.ToInt32(Console.ReadLine());

            if (Denominator1 == 0)
            {
                Console.WriteLine("Знаменатель не может быть равным 0");
                Environment.Exit(0);
            }

            Fraction Fraction1 = new Fraction(Numerator1, Denominator1);

            Console.Write("Введите числитель второй дроби: ");
            int Numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель второй дроби: ");
            int Denominator2 = Convert.ToInt32(Console.ReadLine());

            if (Denominator2 == 0)
            {
                Console.WriteLine("Знаменатель не может быть равным 0");
                Environment.Exit(0);
            }

            Fraction Fraction2 = new Fraction(Numerator2, Denominator2);

            Console.Write("Введите знак действия: ");
            string Character = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Action.MathAct(Fraction1, Fraction2, Character);
        }
    }
}