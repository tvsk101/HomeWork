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

            Console.Write("Сколькими числами будет введена первая дробь (от 1 до 3): ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Fraction Fraction1 = new Fraction(0, 0);

            if (amount == 1)
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Fraction1 = new Fraction(a);
                Console.WriteLine("Дробь: " + Fraction1);
            }
            else if (amount == 2)
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Fraction1 = new Fraction(a, b);
                Console.WriteLine("Дробь: " + Fraction1);
            }
            else if (amount == 3)
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Fraction1 = new Fraction(a, b, c);
                Console.WriteLine("Дробь: " + Fraction1);
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }

            Console.Write("Сколькими числами будет введена первая дробь (от 1 до 3): ");
            amount = Convert.ToInt32(Console.ReadLine());

            Fraction Fraction2 = new Fraction(0, 0);

            if (amount == 1)
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Fraction2 = new Fraction(a);
                Console.WriteLine("Дробь: " + Fraction2);
            }
            else if (amount == 2)
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Fraction2 = new Fraction(a, b);
                Console.WriteLine("Дробь: " + Fraction2);
            }
            else if (amount == 3)
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Fraction2 = new Fraction(a, b, c);
                Console.WriteLine("Дробь: " + Fraction2);
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }

            Console.Write("Введите знак действия: ");
            string Character = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Action.MathAct(Fraction1, Fraction2, Character);

        }
    }
}