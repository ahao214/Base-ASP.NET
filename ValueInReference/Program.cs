using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueInReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输出用户的年龄信息：");
            MyInfo info = new MyInfo("放大为", 24);
            Console.WriteLine("未改变用户信息前");
            info.PrintInfo();
            SendAPersonByValue(info);
            Console.WriteLine("改变后的用户年龄信息：");
            info.PrintInfo();
            Console.ReadLine();
        }


        public static void SendAPersonByValue(MyInfo info)
        {
            info.MyAge = 99;
            info = new MyInfo("顾丽丽", 99);
        }
    }
}
