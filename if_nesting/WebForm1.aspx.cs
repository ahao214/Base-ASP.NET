using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace if_nesting
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAge_Click(object sender, EventArgs e)
        {
            const int i = 18;
            const int j = 30;
            const int k = 50;
            int yourAge = 0;
            yourAge = Convert.ToInt32(txtAge.Text.Trim());

            if(yourAge<i)
            {
                Page.RegisterClientScriptBlock("", "<script>alert(''你的年龄还小，需要好好奋斗)</script>");
                return;
            }
            else
            {
                if(i<yourAge && yourAge<j )
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
    }
}