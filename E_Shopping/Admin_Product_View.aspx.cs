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
    public partial class Admin_Product_View : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            grid_bind();
           

        }
        public void grid_bind()
        {
            string s = "select * from Tab_Product";
            DataSet ds = obj.fun_ExecuteAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            
            Response.Redirect("Edit_Product.aspx");
            int id = Convert.ToInt32(e.CommandArgument);
            Session["uid"] = id;
            //string sel = "select * from Tab_Category where Category_Id=" + id + "";
            
            //string sel = "select * from Tab_Product";
            //SqlDataReader dr = obj.fun_ExeReader(sel);
            //while(dr.Read())
            //{
            //    TextBox1.Text = dr["Product_Name"].ToString();
            //    Image1.ImageUrl = dr["Product_Image"].ToString();
            //    TextBox2.Text = dr["Product_Price"].ToString();
            //    TextBox3.Text = dr["Product_Description"].ToString();
            //    TextBox4.Text = dr["Product_Stock"].ToString();
            //    TextBox5.Text = dr["Product_Status"].ToString();
            //}
        }
    }
}