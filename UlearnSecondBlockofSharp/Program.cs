class Program
{
    public static void Main(string[] args)
    {
        List<int> years = [1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004];
        int i = 0;
        int numberOfYears = 0;
        int result = GetLeapYear(years, i, numberOfYears);
        Console.Write($"{result}");
    }

    public static int GetLeapYear(List<int> a, int i, int b)
    {
        int result = b;
        if (i > a.Count - 1)
        {
            return result;
        }
        else
        {
            if (a[i] % 4 == 0)
            {
                return GetLeapYear(a, i + 1, result + 1);
            }
            else
            {
                return GetLeapYear(a, i + 1, result);
            }
        }
    }
}