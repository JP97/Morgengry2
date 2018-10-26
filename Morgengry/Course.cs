using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course
    {
        private string name;
        private int durationinMinutes;

        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }
        public Course(string name) : this (name, 0)
        {
        }
        public string Name { get {return name; } set {this.name = value; } }
        public int DurationInMinutes { get {return this.durationinMinutes; } set {this.durationinMinutes = value; } }


        public override string ToString()
        {
            string str = "Name: " + name + ", " + "Duration in Minutes: " + durationinMinutes;
            return str;
        }
    }
}
