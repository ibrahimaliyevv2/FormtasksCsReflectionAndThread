using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionTask
{
    class Group
    {
        public Group()
        {
            _no++;
            No = ($"BP{_no}");
        }
        private int _no=200;
        public string No { get;}
        public int StudentLimit { get; set; }
        private Student[] _students = new Student[0];
        public Student[] Students { get; set; }
        public void AddStudent(Student student)
        {
            if (_students.Length <= StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                throw new CapacityLimitException("Yer yoxdur, basqa qapiya!");
            }
        }
    }
}
