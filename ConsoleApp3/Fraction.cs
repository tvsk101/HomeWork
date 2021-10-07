using System;

namespace HomeWork
{
    public class Fraction
    {
        public double Numerator = 0;
        public double Denominator = 0;

        public Fraction(int Numerator, int Denominator)
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }

        public override string ToString()
        {
            return " " + Numerator.ToString() + "/" + Denominator.ToString() + " ";
        }

        public static Fraction operator +(Fraction Fraction1, Fraction Fraction2)
        {
            Fraction TempFraction = new Fraction(1, 1);
            TempFraction.Numerator = (Fraction1.Numerator * Fraction2.Denominator + Fraction1.Denominator * Fraction2.Numerator);
            TempFraction.Denominator = Fraction1.Denominator * Fraction2.Denominator;
            Fraction.SetFormat(TempFraction);
            return TempFraction;

        }
        public static Fraction operator -(Fraction Fraction1, Fraction Fraction2)
        {
            Fraction TempFraction = new Fraction(1, 1);
            TempFraction.Numerator = (Fraction1.Numerator * Fraction2.Denominator - Fraction1.Denominator * Fraction2.Numerator);
            TempFraction.Denominator = Fraction1.Denominator * Fraction2.Denominator;
            Fraction.SetFormat(TempFraction);
            return TempFraction;

        }
        public static Fraction operator *(Fraction Fraction1, Fraction Fraction2)
        {
            Fraction TempFraction = new Fraction(1, 1);
            TempFraction.Numerator = (Fraction1.Numerator * Fraction2.Numerator);
            TempFraction.Denominator = Fraction1.Denominator * Fraction2.Denominator;
            Fraction.SetFormat(TempFraction);
            return TempFraction;

        }
        public static Fraction operator /(Fraction Fraction1, Fraction Fraction2)
        {
            Fraction TempFraction = new Fraction(1, 1);
            TempFraction.Numerator = (Fraction1.Numerator * Fraction2.Denominator);
            TempFraction.Denominator = (Fraction1.Denominator * Fraction2.Numerator);
            Fraction.SetFormat(TempFraction);
            return TempFraction;
        }
        public static Fraction SetFormat(Fraction Fraction1)
        {

            double max = 0;

            
            if (Fraction1.Numerator > Fraction1.Denominator)
                max = Math.Abs(Fraction1.Denominator);
            else
                max = Math.Abs(Fraction1.Numerator);
                                                    
            for (double i = max; i >= 2; i--)
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
        public string Indexer(int index)
        {
            if (index == 0)
            {
                return Convert.ToString(Numerator);
            }

            if (index == 1)
            {
                return Convert.ToString(Denominator);
            }

            return "Неверный индекс";
        }
    }
}
