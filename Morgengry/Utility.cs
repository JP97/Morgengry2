using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {

        public static double GetValueOfBook(Book b)
        {
            return b.Price;
        }
        public static double GetValueOfAmulet(Amulet a)
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

            else if(a.Quality == Level.medium)
            {
                return value = 20.0;
            }

            return value;
        }
        public static double GetValueOfCourse(Course c)
        {
            double result = 0;
            double value = 875.0;

            double hour1 = c.DurationInMinutes / 60;
            
            int hour2 = 157 / 60;
            if (c.DurationInMinutes == 0)
            {
                return 0.0;
            }
            
            if(hour1 % hour2 != 0)
            {
                result = (hour2 + 1) * value;
            }


            return result;
        }
    }
}
