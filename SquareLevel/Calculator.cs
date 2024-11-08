// nocopy
namespace SquareLevel
{
    public class Calculator
    {

        /// <summary>
        /// Расчитывает  квадратное  уравнение 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>возвращает  сложный объект "SquareEquation" </returns>
        public static SquareEquation GetSquareEquation (double a , double b , double c)
        {

            SquareEquation square = new SquareEquation ();   // создали новый  SquareEquation - см SquareLevel\SquareEquation.cs

            if ( a == 0) 
            {
                square.IsRadix = false ;
                return square ;
            }

            if (a == 0 && b==0 && c==0)
            {
                square.IsRadix = false;
                return square;
            }

            double d = Math.Pow ( b , 2) - (4* a*c) ;

            if ( d < 0 )
            {
                square.IsRadix = false;
                return square ;
            }

            if (d == 0)
            {
                square.IsRadix = true;
                square.radix1 = (-b + Math.Sqrt (d) ) / (2*a);
                square.radix2 = (-b + Math.Sqrt(d)) / (2 * a);
                return square ;
            }

            if (d >0)
            {
                square.IsRadix = true;
                square.radix1 = (-b + Math.Sqrt(d)) / (2 * a);
                square.radix2 = (-b - Math.Sqrt(d)) / (2 * a);
                return square;
            }
            return square ;
        }
    }
}
