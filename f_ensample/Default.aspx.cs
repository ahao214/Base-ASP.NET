using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace f_ensample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            const int totalChicken = 100;
            const int totalMoney = 100;
            const int xMoney = 5;
            const int yMoney = 3;
            const int zMoney = 1;
            const int zNumber = 3;
            for(int x=0;x<=totalChicken;x++)
            {
                for(int y =0;y<= totalChicken;y++)
                {
                    int z = totalChicken - x - y;
                    if(z%zNumber==0)
                    {
                        continue;
                    }
                    z /= zNumber;
                    int sumNumber = x * xMoney + y * yMoney + z * zMoney;
                    if(sumNumber==totalMoney)
                    {
                        Response.Write("公鸡的数量是：" + x.ToString() + "，母鸡的数量是：" + y.ToString() + ",小鸡的数量是：" + z * zNumber + "");
                    }
                }
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Trim().Length == 0)
            {
                //提示信息
                Page.RegisterClientScriptBlock("", "<script>alert('请输入数据！');</script>");
                return;
            }
            if (!Regex.IsMatch(txtNumber.Text.Trim(), @"^\+?[1-9][0-9]*$"))
            {
                Page.RegisterClientScriptBlock("", "<script>alert('请输入大于0的数字');</script>");
                return;
            }
            if (Convert.ToInt32(txtNumber.Text.Trim()) % 2 == 0)
            {
                Page.RegisterClientScriptBlock("", "<script>alert('你输入的是偶数')</script>");
                return;
            }
            if (Convert.ToInt32(txtNumber.Text.Trim()) % 2 != 0)
            {
                Page.RegisterClientScriptBlock("", "<script>alert('你输入的是奇数')</script>");
                return;
            }

        }

        protected void btnAge_Click(object sender, EventArgs e)
        {
            const int i = 18;
            const int j = 30;
            const int k = 50;
            int yourAge = 0;
            yourAge = Convert.ToInt32(txtAge.Text.Trim());

            if (yourAge < i)
            {
                Page.RegisterClientScriptBlock("", "<script>alert('你输入的是偶数')</script>");
                return;
            }
            else
            {
                if (i < yourAge && yourAge < j)
                {
                    Page.RegisterClientScriptBlock("", "<script>alert('你现在的阶段真是努力奋斗的宝贵阶段')</script>");
                    return;
                }
                else
                {
                    Page.RegisterClientScriptBlock("", "<script>alert('最美不过夕阳红')</script>");
                    return;
                }
            }
        }

        protected void btnMonth_Click(object sender, EventArgs e)
        {
            string season = string.Empty;
            int month = Convert.ToInt32(txtMonth.Text.Trim());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "冬季";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "春季";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "夏季";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "秋季";
                    break;
                default:
                    season = "不存在";
                    break;
            }
            txtShow.Text = season;
        }
    }
}