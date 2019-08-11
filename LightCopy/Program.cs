using System;
using static System.Console;

namespace LightCopy
{
    class Program
    {
        /// <summary>
        /// 数据类型之间的复制：包含引用类型的值类型
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("创建第一个MyRectangle变量r1");
            MyRectangle r1 = new MyRectangle("这是我创建的第一个MyRectangle对象");
            WriteLine("现在将一个新的MyRectangle赋值给r1");
            MyRectangle r2 = r1;
            WriteLine("改变r2的值");
            r2.rectInfo.infoString = "这是一个新的字符串信息";
            r2.bottom = 120;
            WriteLine("改变后的新值：");
            WriteLine("r1.rectInfo.infoString:{0}", r1.rectInfo.infoString);
            WriteLine("r2.rectInfo.infoString:{0}", r2.rectInfo.infoString);
            WriteLine("r1.bottom:{0}", r1.bottom);
            WriteLine("r2.bottom:{0}", r2.bottom);
            ReadLine();
        }
    }
}
