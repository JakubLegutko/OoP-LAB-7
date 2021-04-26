using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_7
{
    abstract class Move
    {
        public virtual string Execute(int currentTime) {
            return "Move";
        }
    }
}
