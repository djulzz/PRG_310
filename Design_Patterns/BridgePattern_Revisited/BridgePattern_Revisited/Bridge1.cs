using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_Revisited
{
    public class Bridge1 : IBridge
    {
        public void Operation1( )
        {
            Console.WriteLine("Bridge1 - Operation1 - Running");
        }

        public void Operation2(  )
        {
            Console.WriteLine("Bridge1 - Operation2 - Running");
        }
    }
}
