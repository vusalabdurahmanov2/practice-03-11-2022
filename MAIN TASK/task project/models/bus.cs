using System;
using System.Collections.Generic;
using System.Text;

namespace task_project.models
{
    class bus:vehicle
    {
        public bus(double motor, int cycle, double driveway, string color, int PassangersCount, double speed, int drivetime) : base(cycle, driveway, color, PassangersCount, speed, drivetime)
        {
            this.motor = motor;
        }
    }
}
