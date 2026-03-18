namespace MathUtils;

public static class MathCalculator
{
    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    // BUG: should multiply, but accidentally divides
    public static double Multiply(double a, double b) => a / b;

    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}
