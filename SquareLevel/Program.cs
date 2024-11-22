// nocopy
using SquareLevel;
Console.WriteLine("Калькулятор  квадратного уровнения  ax^2 + bc +c =0");

while (true)
{
    double a = GetDouble("Введите а");
    double b = GetDouble("Введите b");
    double c = GetDouble("Введите c");

    SquareEquation square = Calculator.GetSquareEquation(a, b, c); // статичный метод 

    Console.WriteLine
        ($"Уровнение {square.Templite.A}X^2 + {square.Templite.B}X + {square.Templite.C}=0");

    if(square.IsRadix == false)
    {
        Console.WriteLine("Корней нет");
        continue;
    }
    else
    {
        Console.WriteLine($"Корень 1 {square.Radix1}");
        Console.WriteLine($"Корень 2 {square.Radix2}");
    }
}

double GetDouble(string message)
{
    Console.WriteLine(message);
    
    double result = 0;
    if (double.TryParse( Console.ReadLine() , out  result ) == false)
    {
        Console.WriteLine("Eror");
        return GetDouble(message); // рекурсия
    }
    return result;
}
