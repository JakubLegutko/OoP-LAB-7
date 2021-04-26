using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_7
{
    class MoveSouth : Move
    {
        public override string Execute(int currentTime)
        {
            return base.Execute(currentTime)+" South";
        }
    }
}
