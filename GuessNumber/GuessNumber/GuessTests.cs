using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    public class GuessTests
    {
        public int Test { get; private set; }

        Random random = new Random();

        public int Testes(int numMin = 1, int numMax = 100)
        {
            Test = random.Next(numMin, numMax);
            return Test;
        }
    }
}
