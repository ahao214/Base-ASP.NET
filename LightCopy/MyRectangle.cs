using System;
using System.Collections.Generic;
using System.Text;

namespace LightCopy
{
    struct MyRectangle
    {
        public ShapeInfo rectInfo;
        public int top, left, right, bottom;
        public MyRectangle(string info)
        {
            rectInfo = new ShapeInfo(info);     //实例化类类型
            top = left = 11;
            bottom = right = 10;
        }
    }
}
