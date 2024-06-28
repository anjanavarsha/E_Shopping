using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Shopping
{
    public partial class User_Account_Details : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["userid"]);
            string ins = "insert into Table_Account values(" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + "," + id + ")";
            int i = obj.fun_Non_Query(ins);
            if(i==1)
            {
                Label4.Visible = true;
                Label4.Text = "Success";
            }
        }
    }
}