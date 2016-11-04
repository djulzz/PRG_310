using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_Revisited
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridge1 b1 = new Bridge1();
            Bridge2 b2 = new Bridge2();

            //b1.Operation1();
            //b2.Operation1();

            AbstractBridge bridge = new AbstractBridge(b2);

            bridge.Operation1();
            // This is just to keep the program from desappeating when ran from the debugger
            Console.ReadLine();
        }
    }
}
