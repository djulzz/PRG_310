using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using week2_boiler_plate;

namespace Bridge_Design_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridge1 b1 = new Bridge1();
            Bridge2 b2 = new Bridge2();

            AbstractBridge ab1 = new AbstractBridge( b1 );
            AbstractBridge ab2 = new AbstractBridge( b2 );
        }
    }
}
