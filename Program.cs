using System;

namespace 第一次ZY
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("第一题");
            //Console.WriteLine("请输入姓名");
            //string Name = Console.ReadLine();
            //Console.WriteLine("请输入年龄");
            //string Uage = Console.ReadLine();
            //int Age =int.Parse(Uage);
            //Console.WriteLine("你的名字是{0},你的年龄是{1}",Name,Age);
            //if (Age < 18)
            //    Console.WriteLine("你是一个未成年人");
            //else if (Age >= 18 && Age < 30)
            //    Console.WriteLine("你是一个成年人");
            //else if (Age >= 30 && Age < 50)
            //    Console.WriteLine("你是一个中年人");
            //else 
            //    Console.WriteLine("你是一个老年人");
            //Console.ReadLine();

            Student stu1 = new Student();
            stu1.Id = 2;
            stu1.Name = "TT";
            stu1.Age = 20;

            Student stu2 = new Student("KK", 10);

            stu1.Study(10);
            stu2.Study(5);
            stu1.Study(20);
            stu2.Study(8);
            int x=stu1.GetCount();
            int y = stu2.GetCount();
            Console.WriteLine("一共学了{0}",x);
            Console.WriteLine("一共学了{0}",y);





        }
    }
}
