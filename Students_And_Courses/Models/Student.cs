using Students_And_Courses.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_And_Courses.Models
{
    public class Student : IStudent
    {
        private string name;
        private int number;

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be null");
                }

            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }
            private set
            {
                if (value >= 10000 && value <= 99999)
                {
                    this.number = value;
                }
                else
                {
                    throw new ArgumentException("Number must be between 10000 and 99999");
                }
            }
        }
    }
}
