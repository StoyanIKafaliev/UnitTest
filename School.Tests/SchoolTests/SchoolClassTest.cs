using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students_And_Courses.Contracts;
using Students_And_Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests.SchoolTests
{
    [TestClass]
    public class SchoolClassTest
    {
        [TestMethod]
        public void ShouldCreateSchoolInstance()
        {
            // Arange
            ISchool school = new Students_And_Courses.Models.School();

            // Act & Assert 
            Assert.IsInstanceOfType(school, typeof(ISchool));
        }

        [TestMethod]
        public void ShouldCreateSchoolWithCourse()
        {
            // Arange
            ISchool school = new Students_And_Courses.Models.School();
            ICourse course = new Course();
            IStudent student_1 = new Student("Gosho", 10001);
            IStudent student_2 = new Student("Pesho", 10002);

            // Act
            course.AddStudentToCourse(student_1);
            course.AddStudentToCourse(student_2);
            school.Courses.Add(course);

            // Assert 
            Assert.AreEqual(1, school.Courses.Count);
        }

        [TestMethod]
        public void ShouldRemoveSchoolWithCourse()
        {
            // Arange
            ISchool school = new Students_And_Courses.Models.School();
            ICourse course = new Course();
            IStudent student_1 = new Student("Gosho", 10001);
            IStudent student_2 = new Student("Pesho", 10002);

            // Act
            course.AddStudentToCourse(student_1);
            course.AddStudentToCourse(student_2);
            school.Courses.Add(course);
            school.Courses.Remove(course);

            // Assert 
            Assert.AreEqual(0, school.Courses.Count);
        }


        [TestMethod]
        public void ShouldThrowArgumentExc_RemoveCourseNotFound()
        {
            // Arange
            ISchool school = new Students_And_Courses.Models.School();
            ICourse course = new Course();
            IStudent student_1 = new Student("Gosho", 10001);
            IStudent student_2 = new Student("Pesho", 10002);

            // Act
            course.AddStudentToCourse(student_1);
            course.AddStudentToCourse(student_2);

            // Assert 
            Assert.ThrowsException<ArgumentException>(() => school.RemoveCourse(course));
        }
    }
}
