namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sum = 0;
            while (n > 9)
            {
                sum += n % 10;
                n /= 10;
            }

            sum += n;
            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong sum = 1;
            while (n > 9)
            {
                sum *= n % 10;
                n /= 10;
            }

            sum *= n;
            return sum;
        }
    }
}
