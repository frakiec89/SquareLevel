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
        public static SquareEquation GetSquareEquation(double a, double b, double c)
        {
            SquareEquationTemplite templite = new SquareEquationTemplite(a , b , c);
            SquareEquation square = new SquareEquation(templite);   // создали новый  SquareEquation - см SquareLevel\SquareEquation.cs

            return square;
        }
    }
}
