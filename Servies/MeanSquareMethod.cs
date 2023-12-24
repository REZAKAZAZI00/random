using System.Numerics;

public class MiddleSquareMethod
{
    private string resultString;
    private int n;

    public MiddleSquareMethod(string initialSeed)
    {
        this.resultString = initialSeed;
        this.n = initialSeed.Length;
    }

    public decimal Next()
    {
        var s = BigInteger.Pow(BigInteger.Parse(resultString), 2);
        var sString = s.ToString().PadLeft(n * 2, '0');

        var startIndex = n / 2;
        var endIndex = sString.Length - n / 2;

        var seedString = sString.Substring(startIndex, endIndex - startIndex);

        decimal result;
        if (!decimal.TryParse("0." + seedString, out result))
        {
            result = 0.0m;
        }

        resultString = seedString;

        return result;
    }
}
