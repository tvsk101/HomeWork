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

                // TASK 3 - Get The Fraction Sign
                if ((FinalFraction.Numerator < 0))
                {
                    sign1 = "-";
                }
                Console.WriteLine("Знак дроби: " + sign1);

                // TASK 1 - Decimal Fraction
                double DecimalFract = Convert.ToDouble(FinalFraction.Numerator) / Convert.ToDouble(FinalFraction.Denominator);
                Console.WriteLine("Десятичная дробь: " + DecimalFract);

                Console.WriteLine("Значение по индексу 0: " + FinalFraction[0]);
                Console.WriteLine("Значение по индексу 1: " + FinalFraction[1]);
            }
            else if (Character == "-")
            {
                FinalFraction = Fraction1 - Fraction2;
                Console.WriteLine("Проверка на вычитание: " + Fraction1.ToString() + "-" + Fraction2.ToString() + "=" + FinalFraction.ToString());

                // TASK 3 - Get The Fraction Sign
                if ((FinalFraction.Numerator < 0))
                {
                    sign1 = "-";
                }
                Console.WriteLine("Знак дроби: " + sign1);

                // TASK 1 - Decimal Fraction
                double DecimalFract = Convert.ToDouble(FinalFraction.Numerator) / Convert.ToDouble(FinalFraction.Denominator);
                Console.WriteLine("Десятичная дробь: " + DecimalFract);

                Console.WriteLine("Значение по индексу 0: " + FinalFraction[0]);
                Console.WriteLine("Значение по индексу 1: " + FinalFraction[1]);
            }
            else if (Character == "*")
            {
                FinalFraction = Fraction1 * Fraction2;
                Console.WriteLine("Проверка на умножение: " + Fraction1.ToString() + "*" + Fraction2.ToString() + "=" + FinalFraction.ToString());

                // TASK 3 - Get The Fraction Sign
                if ((FinalFraction.Numerator < 0))
                {
                    sign1 = "-";
                }
                Console.WriteLine("Знак дроби: " + sign1);


                // TASK 1 - Decimal Fraction
                double DecimalFract = Convert.ToDouble(FinalFraction.Numerator) / Convert.ToDouble(FinalFraction.Denominator);
                Console.WriteLine("Десятичная дробь: " + DecimalFract);

                Console.WriteLine("Значение по индексу 0: " + FinalFraction[0]);
                Console.WriteLine("Значение по индексу 1: " + FinalFraction[1]);
            }
            else if (Character == "/")
            {
                FinalFraction = Fraction1 / Fraction2;
                Console.WriteLine("Проверка на деление: " + Fraction1.ToString() + "/" + Fraction2.ToString() + "=" + FinalFraction.ToString());

                // TASK 3 - Get The Fraction Sign
                if ((FinalFraction.Numerator < 0))
                {
                    sign1 = "-";
                }
                Console.WriteLine("Знак дроби: " + sign1);

                // TASK 1 - Decimal Fraction
                double DecimalFract = Convert.ToDouble(FinalFraction.Numerator) / Convert.ToDouble(FinalFraction.Denominator);
                Console.WriteLine("Десятичная дробь: " + DecimalFract);

                Console.WriteLine("Значение по индексу 0: " + FinalFraction[0]);
                Console.WriteLine("Значение по индексу 1: " + FinalFraction[1]);
            }
            else
            {
                Console.WriteLine("Неверно введен знак действия");
            }
        }
    }
}
