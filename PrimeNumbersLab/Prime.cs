using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbersLab
{
    public class Prime
    {
        private static List<int> primes = new List<int>() { 2,3,5,7};
	
        public static int PrimeNum(int n)
        {
            for (int i = primes.Count; i <= 10000; i++)
            {

                
                if (i % 2 != 0)
                {
                    if (i % 3 != 0)
                    {
                        if (i % 5 != 0)
                        {
                            if (i % 7 != 0)
                            {
                                if (Math.Sqrt(i)% i !=0)
                                {
                                primes.Add(i);

                                }
                            }
                        }
                    }
                }
            }



            return primes[n - 1];
        }

       
    }
}
