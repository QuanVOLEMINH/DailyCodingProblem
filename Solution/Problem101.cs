using System;
using QUtils;

namespace Solution
{
    public class Problem101
    {
        public static readonly string OutOfRangeMessage = "Bad Input";
        public static int[] ListPrimes(int input)
        {
            if ((input < 4) || (input % 2 != 0))
            {
                throw new ArgumentOutOfRangeException(nameof(input), input, OutOfRangeMessage);
            }
            if (input == 4)
            {
                return new[] { 2, 2 };
            }
            for (var i = 3; i <= (input / 2); i += 2)
            {
                if (QPrime.IsPrime(i) && QPrime.IsPrime(input - i))
                {
                    return new[] { i, input - i };
                }
                continue;
            }
            return null;
        }
    }
}
