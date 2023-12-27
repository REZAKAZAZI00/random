namespace random.Servies
{
    public class ConstantMultiplicationMethod
    {
        private string _k;
        private string _x;
        private int n;
        public ConstantMultiplicationMethod(string k, string x)
        {

            _k = k;
            _x = x;
            this.n = k.Length;
        }

        public decimal Next()
        {
            decimal k = decimal.Parse(_k);
            decimal x = decimal.Parse(_x);

            decimal product = k * x;

            var sString = product.ToString().PadLeft(n * 2, '0');

            var startIndex = n / 2;
            var endIndex = sString.Length - n / 2;

            var seedString = sString.Substring(startIndex, endIndex - startIndex);

            decimal result;
            if (!decimal.TryParse("0." + seedString, out result))
            {
                result = 0.0m;
            }

            _x = seedString;

            return result;
        }
    }
}
