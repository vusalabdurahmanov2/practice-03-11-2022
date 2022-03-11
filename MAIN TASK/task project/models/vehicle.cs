using System;
using System.Collections.Generic;
using System.Text;

namespace task_project.models
{
    class vehicle
    {
        public int cycle;
        public double motor;
        public double driveway;
        public string color;
        public int PassangersCount;
        public double speed;
        public int drivetime;

        public vehicle()
        {
        }
        public vehicle(double driveway)
        {
            this.driveway = driveway;
        }
        public vehicle(int cycle, double driveway):this(driveway)
        {
            this.cycle = cycle;
        }
        public vehicle(int cycle, double driveway,string color ) : this(cycle, driveway)
        {
            this.color = color;
        }
        public vehicle(int cycle, double driveway, string color, int PassangersCount) : this(cycle, driveway,color)
        {
            this.color = color;
        }
        public vehicle(int cycle, double driveway, string color, int PassangersCount, double speed) : this(cycle, driveway, color, PassangersCount)
        {
            this.speed = speed;
        }
        public vehicle(int cycle, double driveway, string color, int PassangersCount, double speed,int drivetime) : this(cycle, driveway, color, PassangersCount, speed)
        {
            this.drivetime = drivetime;
        }
        public double GetSpeed()
        {
            double speed =driveway / drivetime;
            return speed;


        }
    }
}
