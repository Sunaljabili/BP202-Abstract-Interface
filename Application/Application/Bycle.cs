using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class Bycle : Vehicle
    {
        public override void Drive(double distance)
        {
            Millage += distance;
        }
    }
}
