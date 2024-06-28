using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Shopping
{
    public partial class User_Registration : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(User_Id) from Table_Login";
            string userid = obj.fun_Scalar(sel);
            int user_id = 0;
            if (userid == "")
            {
                user_id = 1;
            }
            else
            {
                int newuserid = Convert.ToInt32(userid);
                user_id = newuserid + 1;
            }
            string ins = "insert into Tab_User_Registration values(" + user_id + ",'" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "'," + TextBox4.Text + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "'," + TextBox7.Text + ",'active')";
            int i = obj.fun_Non_Query(ins);
            if (i != 0)
            {
                string inslog = "insert into Table_Login values(" + user_id + ",'" + TextBox8.Text + "','" + TextBox9.Text + "','user','active')";
                int j = obj.fun_Non_Query(inslog);
            }
            if(i==1)
            {
                Label12.Text = "inserted";
            }
        }

    }
    
}