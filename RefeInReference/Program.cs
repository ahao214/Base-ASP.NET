using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefeInReference
{
    class Program
    {
        /// <summary>
        /// 按引用传递引用类型
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("输出用户的年龄信息：");
            MyInfo info = new MyInfo("房大为", 55);
            Console.WriteLine("未改变用户信息前");
            info.PrintInfo();
            SendAPersonByValue(ref info);
            Console.WriteLine("改变后的用户年龄信息：");
            info.PrintInfo();
            Console.ReadLine();
        }

        public static void SendAPersonByValue(ref MyInfo info)
        {
            info.MyAge = 25;
            info = new MyInfo("顾丽丽", 25);
        }
    }
}
