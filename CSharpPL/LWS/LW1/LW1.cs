namespace CSharpPL.LWS;

public static class LW1
{
    public static void LW1T1()
    {
        Console.Write("x = ");
        var x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        var y = Convert.ToDouble(Console.ReadLine());
        Console.Write("z = ");
        var z = Convert.ToDouble(Console.ReadLine());
        double expression1 = 6 / (x - 0.75 * y), expression2 = (5 * y) / (1 - z);
        var result = Math.Pow(expression1 + expression2, 1f / 4f);
        Console.WriteLine(result);
    }
    
    public static void LW1T2()
    {
        Console.Write("a = ");
        var a = Convert.ToDouble(Console.ReadLine());
        Console.Write("n = ");
        var n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0 )
        {
            Console.WriteLine("Исходные данные не верны!");
            return;
        }
        const int NUMERATOR = 1;
        var result = 0.0;
        int pow = 1, end = 2 * n - 2;
        while (pow <= end)
        {
            result += NUMERATOR / Math.Pow(a, pow);
            pow *= 2;
        }
        Console.WriteLine(result);
    }
    
    public static void LW1T3()
    {
        Console.Write("matrix rows and columns = ");
        var n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("error: n is less than or equal to 0");
            return;
        }
        var rand = new Random();
        var matrix = new int[n, n];
        for (var i = 0; i < n; i++)
        {
            Console.Write("|");
            for (var j = 0; j < n; j++)
            {
                matrix[i, j] = rand.Next(0, 10);
                Console.Write($" {matrix[i, j]} |");
            }
            Console.WriteLine();
        }
        int sum = 0, count = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n - i; j++)
            {
                if (matrix[i, j] % 2 != 0) continue;
                sum += matrix[i, j];
                count++;
            }
        }
        Console.WriteLine($"Сумма четных элементов: {sum}");
        Console.WriteLine($"Количество четных элементов: {count}");
    }
}