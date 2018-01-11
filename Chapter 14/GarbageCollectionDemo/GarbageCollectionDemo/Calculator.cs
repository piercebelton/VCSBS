using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }
        public int Divide(int first, int second)
        {
            return first / second;
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator is being finalized");
        }

    }
}
