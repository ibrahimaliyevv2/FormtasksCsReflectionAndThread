using System;
using System.Reflection;

namespace ReflectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Israfil", "Esrefli", 45);
            Student student2 = new Student("Asif", "Ellezov", 46);

            Group group1 = new Group();
            group1.AddStudent(student1);
            group1.AddStudent(student2);

            double sum = 0;

            Type typeGroup = typeof(Group);
            foreach (var item in typeGroup.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
            {
                if (item.Name == "_students")
                {

                    foreach (var item2 in (Student[])item.GetValue(group1))
                    {
                        sum += item2.Point;
                    }
                }
            }
        }

       
    }

}
