using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace E_Shopping
{
    public partial class Product : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select Category_Id,Category_Name from Tab_Category";
                DataSet ds = obj.fun_ExecuteAdapter(s);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Category_Name";
                DropDownList1.DataValueField = "Category_Id";
                DropDownList1.DataBind();


            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string proins = "insert into Tab_Product values("+DropDownList1.SelectedItem.Value+",'"+TextBox1.Text+"','"+p+"',"+TextBox2.Text+",'"+TextBox3.Text+"','"+TextBox4.Text+"','"+DropDownList2.SelectedItem.Text+"')";
            int i = obj.fun_Non_Query(proins);
            if(i==1)
            {
                Label8.Text = "items added";
            }
        }
    }
}