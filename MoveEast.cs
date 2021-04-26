using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_7
{
    class MoveEast : Move
    {
        public override string Execute(int currentTime)
        {
            if ((currentTime < 5 && currentTime > 0) || (currentTime > 12 && currentTime < 25))
                return base.Execute(currentTime) + " East";
            else 
                return base.Execute(currentTime) + " East and cover eyes";

        }
    }
}
