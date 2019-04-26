using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_State
{
    abstract class State
    {
        public int TemplateMethod()
        {
            int result = 1;
            result += PrivateMethod1();
            result += PrivateMethod2();
            result += Hook();
            return result;
        }

        protected virtual int Hook() => 0;
        protected abstract int PrivateMethod2();
        protected abstract int PrivateMethod1();

        public virtual string PublicMethod() => "Default";

        public static State GetState(int stateId)
        {
            switch (stateId)
            {
                case 1:
                    return new State1();
                case 2:
                    return new State2();
                default:
                    return null;
            }
        }
    }
}
