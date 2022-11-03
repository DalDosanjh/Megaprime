using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPrime
{
    internal class MegaPrimeDeterminator
    {
        public static List<uint> GetMegaPrimes(uint maxNumber)
        {
            List<uint> filteredMegaPrimes = new List<uint>();

            for (uint i = (uint)maxNumber; i >=2; i--) //anything less than 2 is not prime
            {
                if (IsPrime(i))
                    {
                        if (i < 10) //if it's not more than 1 digit
                        {
                            filteredMegaPrimes.Add(i);
                        }
                        else
                        {
                            if (IsMegaPrime(i))
                            {
                            filteredMegaPrimes.Add(i);
                            }
                        }
                    }
            }

            return filteredMegaPrimes;
        }

        private static bool IsPrime(uint potentialPrime)
        {
            if (potentialPrime == 1)
            {
                return false;
            }

            for (int i = 2; i <= potentialPrime-1; i++)
            {
                //n-1 because you don't need to check if it can divide by itself, so every number from 2 to one less than itself 
                 
                if (potentialPrime % i == 0)  //Modulus operator returns the division remainder
                    //a prime number always has a remainder. Return false if there is an iteration where there is no remainder
                    return false;                 
            }

            return true;
        }

        public static int[] GetSplitDigits(uint number)
        {
            string temp = number.ToString();
            int[] rtn = new int[temp.Length];
            for (int i = 0; i < rtn.Length; i++)
            {
                rtn[i] = int.Parse(temp[i].ToString());
            }
            return rtn;
        }

        private static bool IsMegaPrime(uint numberToCheck)
        {
            //Iterate through each digit in the integer numberToCheck. 
            int[] splitDigits;
            bool isMegaPrime = true;

            splitDigits = GetSplitDigits(numberToCheck);

            foreach (uint digit in splitDigits)
            {
                if (IsPrime(digit) == false)
                {
                    isMegaPrime = false;
                    break;
                }
            }

            return isMegaPrime;
        }
    }
}
