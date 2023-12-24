namespace random.Servies
{
    public class LinearCongruentialGenerator
    {
        private long x;
        private long a;
        private long c;
        private long m;

        public LinearCongruentialGenerator(long x, long a, long c, long m)
        {
            this.x = x;
            this.a  = a;
            this.c = c;
            this.m = m;
        }

        public int Next()
        {
            x = (a * x + c) % m;
            return (int)x;
        }
    }
}
