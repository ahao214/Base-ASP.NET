using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueInReference
{
    class MyInfo
    {
        public string MyName;
        public int MyAge;

        public MyInfo(string name ,int age)
        {
            MyName = name;
            MyAge = age;
        }

        public MyInfo()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine("{0}的年龄是{1}", MyName, MyAge);
        }

       
    }
}
