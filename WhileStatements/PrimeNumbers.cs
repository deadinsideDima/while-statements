namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            uint m = n;
            uint i = 2;
            if (m == 0 || m == 1)
            {
                return false;
            }

            while (i < m)
            {
                if (n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            uint result = 0;
            uint i = 1;
            while (i <= n)
            {
                bool p = true;
                uint m = i / 2;
                if (i == 0 || i == 1)
                {
                    p = false;
                }

                uint j = 2;
                while (j <= m)
                {
                    if (i % j == 0)
                    {
                        p = false;
                    }

                    j++;
                }

                if (p)
                {
                    result = i;
                }

                i++;
            }

            return result;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint result = 0;
            uint i = n;
            while (i > 0)
            {
                bool p = true;
                uint m = i / 2;
                if (i == 1 || i == 0)
                {
                    p = false;
                }

                uint j = 2;
                while (j <= m)
                {
                    if ((i % j) == 0)
                    {
                        p = false;
                    }

                    j++;
                }

                if (p)
                {
                    if (count > 0)
                    {
                        result += i;
                        count--;
                    }
                    else
                    {
                        return result;
                    }
                }

                i--;
            }

            return result;
        }
    }
}
