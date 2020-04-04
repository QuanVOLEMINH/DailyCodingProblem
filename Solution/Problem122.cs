using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class Problem122
    {

        public static int GetMaxCoins(int[,] matrix)
        {
            var result = 0;
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }
            return 0;
        }
    }


}
