using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_7
{
    class MoveWest : Move
    {
        public override string Execute(int currentTime)
        {
            if ((currentTime < 15 && currentTime > 0) || (currentTime > 20 && currentTime < 25))
                return base.Execute(currentTime) + " West";
            else 
                return base.Execute(currentTime) + " West and cover eyes";

        }
    }
}
