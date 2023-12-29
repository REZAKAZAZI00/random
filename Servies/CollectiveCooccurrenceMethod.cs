namespace random.Servies
{
    public class CollectiveCooccurrenceMethod
    {
        private int[] sequence;
        private int currentIndex;

        public CollectiveCooccurrenceMethod(int[] x, int n, int m)
        {
            sequence = new int[x.Length + n];
            Array.Copy(x, sequence, x.Length);
            currentIndex = n;

            for (int i = n; i < x.Length + n; i++)
            {
                sequence[i] = (sequence[i - 1] + sequence[i - n]) % m;
            }
        }

        public int Next()
        {
            int result = sequence[currentIndex];
            currentIndex = (currentIndex + 1) % sequence.Length;
            return result;
        }
    }
}
