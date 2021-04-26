using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_7
{
    class MoveSouth : Move
    {
        public override string Execute(int currentTime)
        {
            if ((currentTime < 12 && currentTime > 0) || (currentTime > 15 && currentTime < 25))
                return base.Execute(currentTime) + " South";
            else 
                return base.Execute(currentTime) + " South and cover eyes";

        }
    }
}
