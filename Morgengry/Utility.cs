using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        private double lowQualityValue;
        private double mediumQualityValue;
        private double highQualityValue;
        private double courseHourValue;

        public double LowQualityValue { get {return this.lowQualityValue; } set {this.lowQualityValue = value; } }
        public double MediumQualityValue { get {return this.mediumQualityValue; } set {this.mediumQualityValue = value; } }
        public double HighQualityValue { get {return this.highQualityValue; } set {this.highQualityValue = value; } }
        public double CourseHourValue { get { return this.courseHourValue; } set { this.courseHourValue = value; } }

        public static double GetValueOfMerchandise(Merchandise m1)
        {
            double result = 0;
            if (m1 is Book b)
            {
                result = b.Price;
            }
            else if (m1 is Amulet a)
            {
                double value = 0;
                if (a.Quality == Level.high)
                {
                    return value = 27.5;
                }

                else if (a.Quality == Level.low)
                {
                    return value = 12.5;
                }

                else if (a.Quality == Level.medium)
                {
                    return value = 20.0;
                }

                return value;
            }
            return result;
        }
        public static double GetValueOfCourse(Course c)
        {
            double hour1 = c.DurationInMinutes / 60.0;
            int hour2 = c.DurationInMinutes / 60;
            double value = 875.0;
            double result = 0;

            if (c.DurationInMinutes > 0)
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
