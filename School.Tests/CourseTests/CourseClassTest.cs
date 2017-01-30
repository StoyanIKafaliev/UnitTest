using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students_And_Courses.Contracts;
using Students_And_Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests.CourseTests
{
    [TestClass]
    public class CourseClassTest
    {
        [TestMethod]
        public void ShouldCreateICourseInstance()
        {
            // Arange
            ICourse course = new Course();

            // Act & Assert 
            Assert.IsInstanceOfType(course, typeof(ICourse));
        }

        [TestMethod]
        public void ShouldCreateCoursWithStudents()
        {
            // Arange
            ICourse course = new Course();
            IStudent student_1 = new Student("Gosho", 10001);
            IStudent student_2 = new Student("Pesho", 10021);
            IStudent student_3 = new Student("Mitko", 10041);
            IStudent student_4 = new Student("Ivan", 10005);

            // Act
            course.AddStudentToCourse(student_1);
            course.AddStudentToCourse(student_2);
            course.AddStudentToCourse(student_3);
            course.AddStudentToCourse(student_4);

            // Assert 
            Assert.AreEqual(4, course.Students.Count);
        }

        [TestMethod]
        public void ShouldReturnArgumentExc_SameNumber()
        {
            // Arange
            ICourse course = new Course();
            IStudent student_1 = new Student("Gosho", 10001);
            IStudent student_2 = new Student("Pesho", 10001);

            // Act
            course.AddStudentToCourse(student_1);

            // Assert 
            Assert.ThrowsException<ArgumentException>(() => course.AddStudentToCourse(student_2));
        }

        [TestMethod]
        public void ShouldReturnArgumentExc_CourseIsFull()
        {
            // Arange
            ICourse course = new Course();

            // Act & Assert 
            Assert.ThrowsException<ArgumentException>(() =>
            {
                for (int i = 0; i < 32; i++)
                {
                    IStudent student_1 = new Student("Gosho" + i, 10001 + i);

                    course.AddStudentToCourse(student_1);
                }
            });
        }

        [TestMethod]
        public void ShouldReturnArgumentExc_RemoveUserNotFound()
        {
            // Arange
            ICourse course = new Course();
            IStudent student_1 = new Student("Gosho", 10001);

            // Act & Assert 
            Assert.ThrowsException<ArgumentException>(() => course.RemoveStudentFromCourse(student_1));

        }

        [TestMethod]
        public void ShouldRemoveUser_ReturnTrue()
        {
            // Arange
            ICourse course = new Course();
            IStudent student_1 = new Student("Gosho", 10001);
            IStudent student_2 = new Student("Pesho", 10021);
            IStudent student_3 = new Student("Mitko", 10041);
            IStudent student_4 = new Student("Ivan", 10005);

            // Act
            course.AddStudentToCourse(student_1);
            course.AddStudentToCourse(student_2);
            course.AddStudentToCourse(student_3);
            course.AddStudentToCourse(student_4);
            course.RemoveStudentFromCourse(student_4);

            // Assert 
            Assert.AreEqual(3, course.Students.Count);
        }

    }
}

