using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Shopping
{
    public partial class Login : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(User_id) from Table_Login where Username='" + TextBox1.Text + "' and Password ='" + TextBox2.Text + "'";
            string cid = obj.fun_Scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select User_Id from Table_Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string userid = obj.fun_Scalar(str1);
                Session["userid"] = userid;
                string str2 = "select Log_Type from Table_Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string logtype = obj.fun_Scalar(str2);
                if (logtype == "admin")
                {
                    Response.Redirect("Admin_Home.aspx");

                    //Label3.Text = "Admin";
                }
                else if (logtype == "user")
                {
                    Response.Redirect("User_Home.aspx");
                    //Label3.Text = "User";
                }
            }

        }
    }
}