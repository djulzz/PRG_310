﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week2_boiler_plate
{
    public class AbstractBridge : IAbstractBridge
    {

        public IBridge bridge;

        public AbstractBridge(IBridge bridge)
        {
            this.bridge = bridge;
        }

        public void CallMethod1()
        {
            this.bridge.Function1();
        }

        public void CallMethod2()
        {
            this.bridge.Function2();
        }
    }
}