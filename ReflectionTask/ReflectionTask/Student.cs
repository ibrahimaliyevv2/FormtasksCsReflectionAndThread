using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionTask
{
    class Student
    {
        public Student(string name, string surname, byte point)
        {
            Name = name;
            Surname = surname;
            Point = point;
        }

        private byte _age;
        private double _point;
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { 
            get=>_age;
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
            }
        }
        public double Point { 
            get=>_point;
            set 
            {
                if(value>0 && value < 100)
                {
                    _point = value;
                }
            } 
        }
    }
}
