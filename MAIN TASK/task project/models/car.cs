using System;
using System.Collections.Generic;
using System.Text;
using task_project.models;

namespace task_project.models
{
    class car: vehicle 
    {

        public car(double motor,int cycle, double driveway,string color, int PassangersCount, double speed,int drivetime) :base(cycle,driveway,color, PassangersCount, speed,drivetime)
        {
            this.motor = motor;
        }
    }
}
