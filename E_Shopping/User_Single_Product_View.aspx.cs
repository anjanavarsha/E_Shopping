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
    public partial class User_Single_Product_View : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
           
                string s = "select * from Tab_Product where Product_Id=" + Session["sinproid"] + "";
                SqlDataReader dr = obj.fun_ExeReader(s);
                while (dr.Read())
                {
                    Label2.Text = dr["Product_Name"].ToString();
                    Label3.Text = dr["Product_Description"].ToString();
                    Label4.Text = dr["Product_Price"].ToString();
                    Image1.ImageUrl = dr["Product_Image"].ToString();
               }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select max(Cart_ID) from Table_Cart";
            string cartid = obj.fun_Scalar(s);
            int Cart_Id = 0;
            if (cartid == "")
            {
                Cart_Id = 1;
            }
            else
            {
                int newcartid = Convert.ToInt32(cartid);
                Cart_Id = newcartid + 1;
            }
            string sel = "select Product_Price from Tab_Product where Product_Id=" + Session["sinproid"] + "";
            string price = obj.fun_Scalar(sel);
            int q = Convert.ToInt32(TextBox1.Text);
            int p = Convert.ToInt32(price);
            int total_price = q * p;
            string d = "insert into Table_Cart values(" + Cart_Id + "," + Session["sinproid"] + "," + Session["userid"] + ",'" + TextBox1.Text + "'," + total_price + ",'available')";
            int i = obj.fun_Non_Query(d);
            if (i == 1)
            {
                Label1.Visible = true;
                Label1.Text = "Added to cart";
            }
            Label1.Text = price;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
                     
            Response.Redirect("User_Home.aspx");
        }
    }
}