using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一次ZY
{
    class Student
    {
        public Student()
        { }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        private int age;
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name { get; set; }
        public string Phone { get; set; }

        private int count = 0;

        public void Study(int n)
        {
            Console.WriteLine("今天学了{0}节课",n);
            count += n;
        }
        public int GetCount()
        {
            return count;
        }

    }
}
