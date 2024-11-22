// nocopy

namespace SquareLevel
{
    public class SquareEquation
    {

        public SquareEquation(SquareEquationTemplite templite )
        {
            Templite = templite;
        }

        /// <summary>
        /// a , b , c  в уровнении 
        /// </summary>
        public SquareEquationTemplite Templite { get; private set; }

        /// <summary>
        /// корень 1
        /// </summary>
        public double Radix1 { get { return GetRadix1(); }}
        /// <summary>
        ///корень 2
        /// </summary>
        public double Radix2 { get;  }
        /// <summary>
        /// Дескрименант
        /// </summary>
        public double Discriminant { get { return GetDiscriminant(); }}

        /// <summary>
        /// еслть ли корни
        /// </summary>
        public bool IsRadix { get { return GetIsRadix(); }}

        // методы 

        /// <summary>
        /// есть  ли корни
        /// </summary>
        /// <returns></returns>
        private bool GetIsRadix()
        {
            if (Templite.A == 0 && Templite.B == 0)
                return false;

            if (this.Discriminant < 0)
                return false;

            return true;
        }

        /// <summary>
        /// найти дискременант 
        /// </summary>
        /// <returns></returns>
        private double GetDiscriminant()
        {
            return Math.Pow(Templite.B, 2) - (4 * Templite.A * Templite.C);
        }

        /// <summary>
        ///поиск  первого  корня 
        /// </summary>
        /// <returns></returns>
        private double GetRadix1()
        {
            if (IsRadix == true)
                return (-1 * Templite.B + Math.Sqrt(this.Discriminant)) / (2 * Templite.A);

            return 0;  // пока так
        }

        /// <summary>
        /// поиск второго корня 
        /// </summary>
        /// <returns></returns>
        private double GetRadix2()
        {
            if (IsRadix == true)
                return (-1 * Templite.B - Math.Sqrt(this.Discriminant)) / (2 * Templite.A);
            
            return 0; // пока так
        }
    }

    public class SquareEquationTemplite
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public SquareEquationTemplite(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

    }
}
