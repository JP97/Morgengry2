using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : IValuable
    {
        private string name;
        private int durationInMinutes;
        private double courseHourValue = 825.0;

        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }

        public Course(string name) : this (name, 0)
        {
            
        }
        
        //test kommentar

        public string Name { get {return name; } set {this.name = value; } }
        public int DurationInMinutes { get {return this.durationInMinutes; } set {this.durationInMinutes = value; } }
        public double CourseHourValue { get {return this.courseHourValue; } set {this.courseHourValue = value; } }


        public override string ToString()
        {
            string str = "Name: " + name + ", " + "Duration in Minutes: " + durationInMinutes + ", " + "Pris pr påbegyndt time: " + CourseHourValue;
            return str;
        }

        public double GetValue()
        {
            double hour1 = DurationInMinutes / 60.0;
            int hour2 = DurationInMinutes / 60;
            double value =CourseHourValue;
            double result = 0;

            if (DurationInMinutes > 0)
            {
                if (hour1 % hour2 == 0.0)
                {
                    return result = hour2 * value;
                }
                else
                {
                    return result = value * (hour2 + 1);
                }

            }

            return result;
        }

     
    }
}
