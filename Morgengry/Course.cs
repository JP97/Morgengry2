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
            DurationinMinutes = duration;
        }

        public string Name { get {return name; } set {this.name = value; } }
        public int DurationinMinutes { get {return this.durationinMinutes; } set {this.durationinMinutes = value; } }
    }
}
