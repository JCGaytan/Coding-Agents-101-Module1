namespace MathUtils;

public static class MathCalculator
{
    public static double Add(double a, double b) => a + b; // fixed: changed - to +

    public static double Subtract(double a, double b) => a - b; // fixed: changed + to -

    public static double Multiply(double a, double b) => a * b; // fixed: changed / to *

    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}
