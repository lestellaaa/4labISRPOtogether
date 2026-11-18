public class Calc
{
    public int sum(int a, int b)
    {
        return a + b;
    }

    public int minus(int a, int b)
    {
        return a - b;
    }

    public int multiplex(int a, int b)
    {
        return a * b;
    }

    public int division(int a, int b)
    {
        if (b != = 0)
        {
            return a / b
        }
        else
        {
            Console.WriteLine("Division by zero");
        }
    }
}