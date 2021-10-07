using System;

namespace HomeWork
{
    public class Action
    {
        public static void MathAct(Fraction Fraction1, Fraction Fraction2, string Character)
        {
            Fraction FinalFraction;
            string sign1 = "+";

            if (Character == "+")
            {
                FinalFraction = Fraction1 + Fraction2;
                Console.WriteLine("Проверка на сложение: " + Fraction1.ToString() + "+" + Fraction2.ToString() + "=" + FinalFraction.ToString());

                if ((FinalFraction.Numerator < 0))
                {
                    sign1 = "-";
                }
                Console.WriteLine("Знак дроби: " + sign1);

                double DecimalFract = FinalFraction.Numerator / FinalFraction.Denominator;
                Console.WriteLine("Десятичная дробь: " + DecimalFract);

                Console.Write("Введите индекс нужного элемента дроби: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Значение по индексу: " + FinalFraction.Indexer(index));
            }
            else if (Character == "-")
            {
                FinalFraction = Fraction1 - Fraction2;
                Console.WriteLine("Проверка на вычитание: " + Fraction1.ToString() + "-" + Fraction2.ToString() + "=" + FinalFraction.ToString());

                if ((FinalFraction.Numerator < 0))
                {
                    sign1 = "-";
                }
                Console.WriteLine("Знак дроби: " + sign1);

                double DecimalFract = FinalFraction.Numerator / FinalFraction.Denominator;
                Console.WriteLine("Десятичная дробь: " + DecimalFract);

                Console.Write("Введите индекс нужного элемента дроби: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Значение по индексу: " + FinalFraction.Indexer(index));
            }
            else if (Character == "*")
            {
                FinalFraction = Fraction1 * Fraction2;
                Console.WriteLine("Проверка на умножение: " + Fraction1.ToString() + "*" + Fraction2.ToString() + "=" + FinalFraction.ToString());

                if ((FinalFraction.Numerator < 0))
                {
                    sign1 = "-";
                }
                Console.WriteLine("Знак дроби: " + sign1);

                double DecimalFract = FinalFraction.Numerator / FinalFraction.Denominator;
                Console.WriteLine("Десятичная дробь: " + DecimalFract);

                Console.Write("Введите индекс нужного элемента дроби: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Значение по индексу: " + FinalFraction.Indexer(index));
            }
            else if (Character == "/")
            {
                FinalFraction = Fraction1 / Fraction2;
                Console.WriteLine("Проверка на деление: " + Fraction1.ToString() + "/" + Fraction2.ToString() + "=" + FinalFraction.ToString());

                if ((FinalFraction.Numerator < 0))
                {
                    sign1 = "-";
                }
                Console.WriteLine("Знак дроби: " + sign1);

                double DecimalFract = FinalFraction.Numerator / FinalFraction.Denominator;
                Console.WriteLine("Десятичная дробь: " + DecimalFract);

                Console.Write("Введите индекс нужного элемента дроби: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Значение по индексу: " + FinalFraction.Indexer(index));
            }
            else
            {
                Console.WriteLine("Неверно введен знак действия");
            }
        }
    }
}
