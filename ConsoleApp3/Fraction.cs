using System;

namespace HomeWork
{
    // Realisation of a Fraction class 
    public class Fraction
    {
        // Method overloading
        public int Numerator;
        public int Denominator;

        public Fraction(int a)
        {
            Numerator = a;
            Denominator = 1;
        }
        public Fraction(int a, int b)

        {
            Numerator = a;
            Denominator = b;
        }
        public Fraction(int a, int b, int c)

        {
            Numerator = (a * c) + b;
            Denominator = c;
        }

        // Method that convert Fractions to string type to output in console
        public override string ToString()
        {
            return " " + Numerator.ToString() + "/" + Denominator.ToString() + " ";
        }

        // TASK 2 - Main Mathematical Operations
        // Operator "+"
        public static Fraction operator + (Fraction Fraction1, Fraction Fraction2)
        {
            Fraction TempFraction = new Fraction(1, 1);
            TempFraction.Numerator = (Fraction1.Numerator * Fraction2.Denominator + Fraction1.Denominator * Fraction2.Numerator);
            TempFraction.Denominator = Fraction1.Denominator * Fraction2.Denominator;
            Fraction.SetFormat(TempFraction);
            return TempFraction;

        }

        // Operator "-"
        public static Fraction operator - (Fraction Fraction1, Fraction Fraction2)
        {
            Fraction TempFraction = new Fraction(1, 1);
            TempFraction.Numerator = (Fraction1.Numerator * Fraction2.Denominator - Fraction1.Denominator * Fraction2.Numerator);
            TempFraction.Denominator = Fraction1.Denominator * Fraction2.Denominator;
            Fraction.SetFormat(TempFraction);
            return TempFraction;

        }

        // Operator "*"
        public static Fraction operator * (Fraction Fraction1, Fraction Fraction2)
        {
            Fraction TempFraction = new Fraction(1, 1);
            TempFraction.Numerator = (Fraction1.Numerator * Fraction2.Numerator);
            TempFraction.Denominator = Fraction1.Denominator * Fraction2.Denominator;
            Fraction.SetFormat(TempFraction);
            return TempFraction;

        }

        // Operator "/"
        public static Fraction operator / (Fraction Fraction1, Fraction Fraction2)
        {
            Fraction TempFraction = new Fraction(1, 1);
            TempFraction.Numerator = (Fraction1.Numerator * Fraction2.Denominator);
            TempFraction.Denominator = (Fraction1.Denominator * Fraction2.Numerator);
            Fraction.SetFormat(TempFraction);
            return TempFraction;
        }

        // Method that controls the format of the fraction and doesnt allow a "-" in the denominator
        // It moves "-" to numerator and then we can assume fraction's sign
        public static Fraction SetFormat(Fraction Fraction1)
        {

            int max = 0;

            if (Fraction1.Numerator > Fraction1.Denominator)
                max = Convert.ToInt32(Math.Abs(Fraction1.Denominator));
            else
                max = Convert.ToInt32(Math.Abs(Fraction1.Numerator));

            for (int i = max; i >= 2; i--)
            {

                if ((Fraction1.Numerator % i == 0) & (Fraction1.Denominator % i == 0))
                {
                    Fraction1.Numerator = Fraction1.Numerator / i;
                    Fraction1.Denominator = Fraction1.Denominator / i;
                }

            }

            if ((Fraction1.Denominator < 0))
            {
                Fraction1.Numerator = -1 * (Fraction1.Numerator);
                Fraction1.Denominator = Math.Abs(Fraction1.Denominator);
            }
            return (Fraction1);
        }

        // TASK 5 - Indexer
        public int this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Numerator;
                }
                else if (index == 1)
                {
                    return Denominator;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
