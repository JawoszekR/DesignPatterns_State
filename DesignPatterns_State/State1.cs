using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_State
{
    class State1 : State
    {
        protected override int PrivateMethod1()
        {
            return 100;
        }

        protected override int PrivateMethod2()
        {
            return 11;
        }
        public override string PublicMethod()
        {
            return "Override";
        }
    }
}
