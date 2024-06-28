using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Shopping
{
    public partial class Category : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into Tab_Category values('" + TextBox1.Text + "','" +p+ "','" + TextBox2.Text + "','"+DropDownList1.SelectedItem.Text+"')";
            int i = obj.fun_Non_Query(ins);
            if(i==1)
            {
                Label5.Text = "inserted";
            }

        }
    }
}