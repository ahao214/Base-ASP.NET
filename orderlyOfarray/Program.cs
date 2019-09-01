using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderlyOfarray
{
    class Program
    {
        /// <summary>
        /// 约瑟夫环问题(使用数组解决)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] intPers = Jose(12, 3, 4);
            Console.WriteLine("出列顺序：");
            for (int i = 0; i < intPers.Length; i++)
            {
                Console.WriteLine(intPers[i] + "");
            }
            Console.ReadLine();

            Console.WriteLine("----------------");
            Console.WriteLine("冒泡排序");
            int[] sum = { 1, 8, 3, 34, 98, 6, 4, 7, 7 };
            Sort(sum);

            Console.WriteLine("快速排序法");
            int[] newDate = new Int32[] { 2, 2, 5, 4, 7, 8, 5, 6, 1, 1 };
            QuickRun(newDate, 0, newDate.Length - 1);
            for (int i = 0; i < newDate.Length; i++)
            {
                Console.WriteLine("{0}", newDate[i]);
            }

            Console.WriteLine("二分查找算法");
            int[] data = new int[] { 0, 2, 3, 4, 6, 7, 8, 10 };
            Console.WriteLine("测试序列为：");
            for(int i=0;i<data .Length;i++)
            {
                Console.Write("{0},", data[i]);
            }
            Console.Write("\r\n");
            Console.WriteLine("查找元素{0},查找结果为：{1}",3, Search(data, 3));
            Console.WriteLine("查找元素{0},查找结果为：{1}", 0, Search(data, 0));
            Console.WriteLine("查找元素{0},查找结果为：{1}", 10, Search(data, 10));
            Console.WriteLine("查找元素{0},查找结果为：{1}", 9, Search(data, 9));

            Console.ReadLine();
        }


        static int[] Jose(int total, int start, int alter)
        {
            int j, k = 0;
            int[] intCount = new int[total + 1];
            int[] intPers = new int[total + 1];
            for (int i = 0; i < total; i++)
            {
                intPers[i] = i;
            }

            for (int i = total; i >= 2; i--)
            {
                start = (start + alter - 1) % i;
                if (start == 0)
                {
                    start = i;
                }
                intCount[k] = intPers[start];
                k++;
                for (j = start + 1; j <= i; j++)
                {
                    intPers[j - 1] = intPers[j];
                }
            }
            intCount[k] = intPers[1];
            return intCount;
        }

        #region 冒泡排序法

        /// <summary>
        /// 冒泡排序法
        /// </summary>
        /// <param name="list"></param>
        static void Sort(int[] list)
        {
            int i, j, temp;
            bool done = false;
            j = 1;
            while ((j < list.Length) && !done)
            {
                done = true;
                for (i = 0; i < list.Length - j; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        done = false;
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
                j++;
            }
            Console.WriteLine("\n排序结果如下：\n");
            for (int d = 0; d < list.Length; d++)
            {
                Console.Write(list[d] + "\n");
            }
            Console.Write("\n\n");
        }

        #endregion


        #region 快速排序法

        /// <summary>
        /// 快速排序法
        /// </summary>
        /// <param name="data">排序数组</param>
        /// <param name="low">排序上限</param>
        /// <param name="high">排序下限</param>
        static void QuickRun(int[] data, int low, int high)
        {
            //简单定义中间值，并以此为一趟快排的分隔点
            //注意这里是一个简单的算法，如果想对这个算法优化的话，可以采取随机的方法来获取分隔点
            int middle = data[(low + high) / 2];
            int i = low;
            int j = high;
            do
            {
                while (data[i] < middle && i < high)    //扫描中值左边元素
                {
                    i++;
                }
                while (data[j] > middle && j > low)    //扫描中值右边元素
                {
                    j--;
                }
                if (i <= j)    //找到一对可以交换的值
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (j > low)
            {
                QuickRun(data, low, j);
            }
            if (i < high)
            {
                QuickRun(data, i, high);
            }
        }

        #endregion

        #region 二分查找算法

        /// <summary>
        /// 二分查找算法
        /// </summary>
        /// <param name="data">有序数组</param>
        /// <param name="val">查找的值</param>
        /// <returns></returns>
        static int Search(int[] data,int val)
        {
            if(data .Length <=0)
            {
                return -1;
            }
            //设置初始上下为数组的上下限
            int low = 0;
            int high = data.Length - 1;
            while(low<=high)
            {
                int middle = (low + high) / 2;
                if(data[middle]==val)
                {
                    return middle;
                }
                else if (data[middle]<val)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }                
            }
            return -1;
        }

        #endregion
    }
}
