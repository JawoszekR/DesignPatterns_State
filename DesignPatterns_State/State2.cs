using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_State
{
    class State2 : State
    {
        protected override int PrivateMethod1()
        {
            return 1;
        }

        protected override int PrivateMethod2()
        {
            return 1;
        }
    }
}
