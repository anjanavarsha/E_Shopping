using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Shopping
{
    public partial class UserFeedback : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into Tab_Feedback values(" + Session["userid"] + ",'" + TextBox1.Text + "','waiting','pending')";
            int i = obj.fun_Non_Query(ins);
            if (i == 1)
            {
                Label3.Visible = true;
                Label3.Text = "Sucess";
            }
        }
    }
}
