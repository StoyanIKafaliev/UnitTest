using Students_And_Courses.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_And_Courses.Models
{
    public class School : ISchool, ISchoolFunction
    {
        private ICollection<ICourse> courses;

        public School()
        {
            this.courses = new HashSet<ICourse>();
        }

        public ICollection<ICourse> Courses
        {
            get { return this.courses; }
        }

        public void AddCourse(ICourse course)
        {
            this.Courses.Add(course);
        }

        public void RemoveCourse(ICourse course)
        {
            if (this.Courses.Contains(course))
            {
                this.Courses.Remove(course);
            }
            else
            {
                throw new ArgumentException("Course not found");
            }
        }
    }
}
