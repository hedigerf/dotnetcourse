using System;

namespace Praktikum_04
{
    public struct Vektor
    {

        public static Vektor operator +(Vektor a, Vektor b)
        {
            return new Vektor(a.XValue + b.XValue, a.YValue + b.YValue, a.ZValue + b.ZValue);
        }

        public static Vektor operator -(Vektor a, Vektor b)
        {
            return new Vektor(a.XValue - b.XValue, a.YValue - b.YValue, a.ZValue - b.ZValue);
        }

        public static Vektor operator *(Vektor a, Vektor b)
        {
            return new Vektor(a.YValue * b.ZValue - a.ZValue * b.YValue, a.ZValue * b.XValue - a.XValue * b.ZValue, a.XValue * b.YValue - a.YValue * b.XValue);
        }
        public static implicit operator Vektor(double a)
        {
            return new Vektor(a, 0, 0);
        }

        public static implicit operator System.Drawing.Point(Vektor a)
        {
            return new System.Drawing.Point((int)a.XValue,(int)a.YValue);
        }

        public static explicit operator double (Vektor a)
        {
            return Math.Pow((Math.Pow(a.XValue, 2.0) + Math.Pow(a.YValue, 2.0) + Math.Pow(a.ZValue, 2.0)), 0.5);
        }

        public double this[int x]
        {
            get
            {
                if (x == 0)
                {
                    return XValue;
                }
                else if (x == 1)
                {
                    return YValue;
                }
                else
                {
                    return ZValue;
                }
            }
        }


        public double XValue { get; }

        public double YValue { get; }

        public double ZValue { get; }

        public Vektor(double xValue, double yValue, double zValue)
        {
            this.XValue = xValue;
            this.YValue = yValue;
            this.ZValue = zValue;
        }

        public override string ToString()
        {
            return "[" + XValue + "," + YValue + "," + ZValue + "]";
        }
        //public Vektor



    }
}

