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

        
        
        Console.WriteLine($"Tổng: {Sum(ar2)}");

    }
}