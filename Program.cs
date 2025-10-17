using System.Globalization;

internal class Program
{
    static Array GenerateMatrix(int m, int n, int l1 = 0, int l2 = 0)
    {
        Array a = Array.CreateInstance(
                        typeof(float),
                        new int[2] { m, n },
                        new int[2] { l1, l2 }
                    );
        Random r = new Random();
        for (int i = a.GetLowerBound(0); i <= a.GetUpperBound(0); i++)
            for (int j = a.GetLowerBound(1); j <= a.GetUpperBound(1); j++)
                a.SetValue(r.Next(1, 10), i, j);
        return a;
    }
    static float Sum(Array ar)
    {
        float sum = 0;
        foreach (float y in ar)
            sum = sum + y;
        return sum;
    }
    static Array MatrixMultiply(Array a, Array b)
    {
        Array result = Array.CreateInstance(
            typeof(float),
            new int[2] { a.GetLength(0), b.GetLength(1) },
            new int[2] { a.GetLowerBound(0), a.GetLowerBound(1) }
        );
        //Tính tích ma trận
        for(int i=result.GetLowerBound(0);
                i<=result.GetUpperBound(0);i++)
            for(int j=result.GetLowerBound(1);
                j <= result.GetUpperBound(1); j++)
            {
                float sum = 0;
                for (int k = a.GetLowerBound(1);
                    k <= a.GetUpperBound(1); k++)
                    sum = sum + (float)a.GetValue(i, k) * (float)b.GetValue(k, j);
                //Console.WriteLine($"{i}x{j}");
                result.SetValue(sum, i, j);
            }
        return result;
    }
    static void PrintMatrix(Array ar)
    {
        for (int i = ar.GetLowerBound(0); i <= ar.GetUpperBound(0); i++) {
            for (int j = ar.GetLowerBound(1); j <= ar.GetUpperBound(1); j++)
                Console.Write("{0, 3}", ar.GetValue(i, j));
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        /*
        Array ar1 = Array.CreateInstance(
                        typeof(int),
                        new int[1] { 5 },
                        new int[1] { 1 }
                    );
        */
        //ar1[1], ar1[2],...,ar1[5]
        Array ar2 = GenerateMatrix(3, 2);
        Array br2 = GenerateMatrix(2, 3);
        PrintMatrix(ar2);
        Console.WriteLine();
        PrintMatrix(br2);
        Console.WriteLine();
        PrintMatrix(MatrixMultiply(ar2, br2));


        
        
        Console.WriteLine($"Tổng: {Sum(ar2)}");

    }
}