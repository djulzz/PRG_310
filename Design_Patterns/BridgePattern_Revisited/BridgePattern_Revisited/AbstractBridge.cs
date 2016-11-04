using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_Revisited
{
    public class AbstractBridge : IAbstractBridge
    {
        private IBridge m_bridge;

        public AbstractBridge(IBridge abstract_bridge)
        {
            m_bridge = abstract_bridge;
        }

        public void Operation1()
        {
            m_bridge.Operation1();
        }

        public void Operation2()
        {
            m_bridge.Operation2();
        }
    }
}
