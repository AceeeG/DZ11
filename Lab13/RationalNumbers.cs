namespace Lab
{
    [DeveloperInfo("Амир", "02, 12, 2023")]
    internal class RationalNumbers
    {
        private int numerator;
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        private int denominator;
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set 
            { 
                denominator = value; 
            }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        public RationalNumbers()
        {

        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        public RationalNumbers(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        /// <summary>
        /// Метод, создающий экземпляр, при условии, что знаменатель не равен нулю
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static RationalNumbers MakeRationalNumber(int numerator, int denominator)
        {
            if (denominator != 0)
            {
                return new RationalNumbers(numerator, denominator);
            }
            else
            {
                return null;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is RationalNumbers num1)
            {
                RationalNumbers num2 = (RationalNumbers)obj;
                if (num1.numerator / num1.denominator == num2.numerator/num2.denominator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private static int GetCollectiveDenominator(int denom1, int denom2)
        {
            int num1 = denom1;
            int num2 = denom2;

            while ((denom1 != 0) && (denom2 != 0))
            {
                if (denom1 > denom2)
                {
                    num1 %= num2;
                }
                else
                {
                    num2 %= num1;
                }
            }

            return (denom1 * denom2) / (num1 + num2);
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        static public bool operator == (RationalNumbers num1, RationalNumbers num2) 
        { 
            if(num1.numerator/num1.denominator == num2.numerator / num2.denominator)
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }
        static public bool operator != (RationalNumbers num1, RationalNumbers num2)
        {
            return !(num1 == num2);
        }
        static public RationalNumbers operator + (RationalNumbers num1, RationalNumbers num2)
        {
            int denom = GetCollectiveDenominator(num1.denominator, num2.denominator);
            int num = (num1.numerator * (denom / num1.denominator)) + (num2.numerator * (denom / num2.denominator));

            return new RationalNumbers(num, denom);
        }
        static public RationalNumbers operator -(RationalNumbers num1, RationalNumbers num2)
        {
            int denom = GetCollectiveDenominator(num1.denominator, num2.denominator);
            int num = (num1.numerator * (denom / num1.denominator)) - (num2.numerator * (denom / num2.denominator));

            return new RationalNumbers(num, denom);
        }
        static public RationalNumbers operator *(RationalNumbers num1, RationalNumbers num2)
        {

            return MakeRationalNumber((num1.numerator * num2.numerator), (num1.denominator * num2.denominator));

        }
        static public RationalNumbers operator /(RationalNumbers num1, RationalNumbers num2)
        {

            return MakeRationalNumber((num1.numerator / num2.numerator), (num1.denominator / num2.denominator));

        }
        public static int operator %(RationalNumbers num1, RationalNumbers num2)
        {
            RationalNumbers num = num1 / num2;
            return (num.numerator % num.denominator);
        }

        static public bool operator > (RationalNumbers num1, RationalNumbers num2)
        {
            int denom = GetCollectiveDenominator(num1.denominator, num2.denominator);
            int numerator1 = num1.numerator * (denom / num1.denominator);
            int numerator2 = num2.numerator * (denom / num1.denominator);
            if(numerator1 > numerator2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator <(RationalNumbers num1, RationalNumbers num2)
        {
            int denom = GetCollectiveDenominator(num1.denominator, num2.denominator);
            int numerator1 = num1.numerator * (denom / num1.denominator);
            int numerator2 = num2.numerator * (denom / num1.denominator);
            if (numerator1 < numerator2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator >=(RationalNumbers num1, RationalNumbers num2)
        {
            if (num1 > num2 || num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator <=(RationalNumbers num1, RationalNumbers num2)
        {
            if (num1 > num2 || num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static RationalNumbers operator ++(RationalNumbers num1)
        {
            return new RationalNumbers(num1.numerator + num1.denominator, num1.denominator);
        }
        public static RationalNumbers operator --(RationalNumbers num1)
        {
            return new RationalNumbers(num1.numerator - num1.denominator, num1.denominator);
        }
        public static explicit operator float(RationalNumbers num1)
        {
            return (float)num1.numerator / num1.denominator;
        }
        public static explicit operator int(RationalNumbers num1)
        {
            return num1.numerator / num1.denominator;
        }

    }
}
