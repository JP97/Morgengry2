using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public double LowQualityValue { get; set; }
        public double MediumQualityValue { get; set; }
        public double HighQualityValue { get; set; }
        public double CourseHourValue { get; set; }

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
