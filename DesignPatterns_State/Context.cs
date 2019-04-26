using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_State
{
    class Context
    {
        State _state;
        public Context()
        {
            _state = State.GetState(1);
        }

        public int GetNumber()
        {
            int res = _state.TemplateMethod();
            _state = State.GetState(1);
            return res;
        }

        public string GetString()
        {
            string res = _state.PublicMethod();
            _state = State.GetState(2);
            return res;
        }
    }
}
