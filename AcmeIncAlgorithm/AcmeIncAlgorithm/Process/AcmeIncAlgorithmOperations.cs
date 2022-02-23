using System;
using System.Collections.Generic;
using System.Linq;

namespace AcmeIncAlgorithm
{
    public class AcmeIncAlgorithmOperations
    {
        public int GetVowelNumber(String DRIVERNAME)
        {
            return DRIVERNAME.Count(driverNameString => "AaEeIiOoUu".Contains(Char.ToLower(driverNameString)));
        }

        public int GetConsonantNumber(String DRIVERNAME)
        {
            return DRIVERNAME.Count(driverNameString => "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxYyZz".Contains(Char.ToLower(driverNameString)));
        }

        public List<int> GetCommonFactor(int NUMBER)
        {
            var factors = new List<int>();
            int max = (int)Math.Sqrt(NUMBER);

            for (int factor = 1; factor <= max; ++factor)
            {
                if (NUMBER % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != NUMBER / factor)
                        factors.Add(NUMBER / factor);
                }
            }
            return factors;
        }
    }
}
