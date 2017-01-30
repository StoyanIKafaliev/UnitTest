
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students_And_Courses.Contracts;
using Students_And_Courses.Models;
using System;

namespace School.Tests.StudentTests
{
    [TestClass]
    public class StudentClassTest
    {
        [TestMethod]
        public void CreateStudentShouldThrowArgumentExcNullName()
        {
            // Arange & Act && Assert
            Assert.ThrowsException<ArgumentException>(() => new Student(null, 1001));
        }

        [TestMethod]
        public void CreateStudent_ShouldThrowArgumentExc_LessThan1000Number()
        {
            // Arange & Act && Assert
            Assert.ThrowsException<ArgumentException>(() => new Student("Gosho", 1));
        }

        [TestMethod]
        public void CreateStudent_ShouldReturnName()
        {
            // Arange 
            IStudent student = new Student("Gosho", 10001);

            // Act & Assert
            Assert.AreSame("Gosho", student.Name);
        }

        [TestMethod]
        public void CreateStudent_ShouldReturnNumber()
        {
            // Arange 
            IStudent student = new Student("Gosho", 10001);

            // Act & Assert
            Assert.AreEqual(10001, student.Number);
        }
    }
}
