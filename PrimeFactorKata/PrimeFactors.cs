using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorKata
{
    public class PrimeFactors
    {
        private int number;
        private int currentPrime = 3;

        List<int> factors = new List<int>();

        public void SetNumber(int num)
        {
            number = num;
        }

        public List<int> GetPrimeFactors()
        {
            AddTwos();
            TestAndAddPrimes();
            return factors;
        }

        private void TestAndAddPrimes()
        {
            while (number != 1)
            {
                if (TestCurrentPrime() == false)
                {
                    currentPrime = GetNextPrime();
                }
            }
        }

        private bool TestCurrentPrime()
        {
            if (number%currentPrime == 0)
            {
                factors.Add(currentPrime);
                number /= currentPrime;
                return true;
            }
            return false;
        }   

        //This guy needs some love but oh well
        private int GetNextPrime()
        {
            currentPrime += 2;
            return currentPrime;

        }

        private void AddTwos()
        {
            while (number % 2 == 0)
            {
                number /= 2;
                factors.Add(2);
            }
        }

    }
}
