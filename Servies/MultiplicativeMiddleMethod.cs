namespace random.Servies
{
    public class MultiplicativeMiddleMethod
    {
        private string xPrime;
        private string x;
        private int n;

        public MultiplicativeMiddleMethod(string xPrime, string x)
        {
            this.xPrime = xPrime;
            this.x = x;
            this.n = xPrime.Length;
        }

        public decimal Next()
        {
            decimal xp = decimal.Parse(xPrime);
            decimal y = decimal.Parse(x);

            decimal product = xp * y;

            var sString = product.ToString().PadLeft(n * 2, '0');

            var startIndex = n / 2;
            var endIndex = sString.Length - n / 2;

            var seedString = sString.Substring(startIndex, endIndex - startIndex);

            decimal result;
            if (!decimal.TryParse("0." + seedString, out result))
            {
                result = 0.0m;
            }

            xPrime = seedString;

            return result;
        }
    }
}
