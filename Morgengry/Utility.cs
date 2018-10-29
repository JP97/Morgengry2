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
                return value = 20.0;
            }

            else if(a.Quality == Level.medium)
            {
                return value = 12.5;
            }

            return value;
        }
        public static double GetValueOfCourse(Course c)
        {
            double value = 0;

            int hour = 157 * 60;
            hour = hour / 3600;

            int a = c.DurationInMinutes ;
            value = hour * a;
            return value;
        }
    }
}
