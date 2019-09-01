using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoetheOfArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个大于6的偶数：");
            int intNum = Convert.ToInt32(Console.ReadLine());
            bool blFlag = ISGDBHArith(intNum);
            if (blFlag)
            {
                Console.WriteLine("{0}能写成两个素数的和，所以其符合哥德巴赫猜想。", intNum);
            }
            else
            {
                Console.WriteLine("猜想错误。");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 判断一个大于6的偶数是否符合哥德巴赫猜想
        /// </summary>
        /// <param name="intNum"></param>
        /// <returns></returns>
        static bool ISGDBHArith(int intNum)
        {
            bool blFlag = false;
            if (intNum % 2 == 0 && intNum > 0)
            {
                for (int i = 1; i <= intNum / 2; i++)
                {
                    bool bl1 = IsPrimeNumber(i);
                    bool bl2 = IsPrimeNumber(intNum - 1);
                    if (bl1 && bl2)
                    {
                        //输出等式
                        Console.WriteLine("{0}={1}+{2}", intNum, i, intNum - 1);
                        blFlag = true;
                    }
                }
            }
            return blFlag;
        }

        /// <summary>
        /// 判断一个数是否是素数
        /// </summary>
        /// <param name="intNum"></param>
        /// <returns></returns>
        static bool IsPrimeNumber(int intNum)
        {
            bool blFlag = true;
            if (intNum == 1 || intNum == 2)
            {
                blFlag = true;
            }
            else
            {
                int sqr = Convert.ToInt32(Math.Sqrt(intNum));
                for (int i = sqr; i >= 2; i--)
                {
                    if (intNum % i == 0)
                    {
                        //如果余数为0，说明不是素数
                        blFlag = false;
                    }
                }
            }
            return blFlag;
        }

    }
}
