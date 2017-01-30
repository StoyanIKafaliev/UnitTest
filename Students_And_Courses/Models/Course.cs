using Students_And_Courses.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_And_Courses.Models
{
    public class Course : ICourse, ICourseFunction
    {
        private ICollection<IStudent> students;

        public Course()
        {
            this.students = new HashSet<IStudent>();
        }

        public ICollection<IStudent> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudentToCourse(IStudent student)
        {
            if (this.Students.Any(x => x.Number == student.Number))
            {
                throw new ArgumentException("Number must be unique !");
            }

            if (this.Students.Count < 30)
            {
                this.students.Add(student);
            }
            else
            {
                throw new ArgumentException("Course is full!");
            }
        }

        public void RemoveStudentFromCourse(IStudent student)
        {
            if (this.Students.Contains(student))
            {
                this.students.Remove(student);
            }
            else
            {
                throw new ArgumentException("Student is not found!");
            }
        }
    }
}
