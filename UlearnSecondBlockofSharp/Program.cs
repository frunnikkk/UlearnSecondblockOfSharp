class Program
{
    public static void Main(string[] args)
    {
        List<int> m = [-1, 3];
        List<int> a = [1, 7];
        List<int> b = [7, 3];
        Console.Write(CalculateTheDistance(m, a, b));
    }

    public static double CalculateTheDistance(List<int> m,List<int> a, List<int> b)
    {
        int A = b[1] - a[1];
        int B = a[0] - a[1];
        int C = b[0] * a[1] - b[1] * a[0];
        double d = (A * m[0] + B * m[1] + C) / Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        return d;
    }
}