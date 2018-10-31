using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course c)
        {
            courses.Add(c);
        }

        public double GetTotalValue()
        {
            double result = 0;
            foreach(Course c in courses)
            {
                result = result + Utility.GetValueOfCourse(c);
            }
            return result;
        }

        public Course GetCourse(string name)
        {
           for(int i = 0; i < courses.Count; i++)
            {
                if(courses[i].Name == name)
                {
                    return courses[i];
                }
            }
            return null;
        }
    }
}
