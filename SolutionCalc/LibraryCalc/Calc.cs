using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalc
{
    public static class Calc
    {
        public static double Somma(double a, double b)
        {
            double ris = 0;
            ris = a + b;
            return ris;
        }
        public static double Divisione(double a, double b)
        {
            double ris = 0;
            ris = a / b;
            return ris;
        }
        public static double Massimo(double a, double b)
        {
            double max = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
        public static double Minimo(double a, double b)
        {
            double min = 0;
            if (a > b)
            {
                min = b;
            }
            else
            {
                min = a;
            }
            return min;
        }
        public static double Media(double a, double b)
        {
            double ris = 0;
            ris = (a + b) / 2;
            return ris;
        }
        public static double Massimo3(double a, double b, double c)
        {
            double max = 0;
            if (a > b && a > c)
            {
                max = a;
            }
            else
            {
                if (b > c)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
            }
            return max;
        }
        public static double Minimo3(double a, double b, double c)
        {
            double min = 0;
            if (a < b && a < c)
            {
                min = a;
            }
            else
            {
                if (b < c)
                {
                    min = b;
                }
                else
                {
                    min = c;
                }
            }
            return min;
        }
        public static double Media3(double a, double b, double c)
        {
            {
                double ris = 0;
                ris = (a + b + c) / 3;
                return ris;
            }
        }
    }
}
