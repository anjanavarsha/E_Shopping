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
    public partial class User_Addto_Cart : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                Grid_bind();
            }
        }
        public void Grid_bind()
        {
            string s = "select Tab_Product.Product_Image,Tab_Product.Product_Name,Tab_Product.Product_Description,Table_Cart.Cart_ID,Table_Cart.Cart_Quantity,Table_Cart.Total_Price,Table_Cart.Status from Tab_Product join Table_Cart on Tab_Product.Product_Id=Table_Cart.Product_Id where User_Id='"+Session["userid"]+"'";
            DataSet ds = obj.fun_ExecuteAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        //protected void LinkButton1_Command(object sender, CommandEventArgs e)
        //{
        //    Session["Cartid"] = Convert.ToInt32(e.CommandArgument);


        //}


        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    string t = "select Tab_Product.Product_Price from Tab_Product join Table_Cart on Tab_Product.Product_Id =.Product_Id where Table_Cart Cart_ID='" + Session["Cartid"] + "'";
        //    string f = obj.fun_Scalar(t);
        //    int q = Convert.ToInt32(TextBox1.Text);
        //    int p = Convert.ToInt32(f);
        //    int t_Price = q * p;
        //    string m = "update Table_Cart set Cart_Quantity='" + TextBox1.Text + "',Total_Price='" + t_Price + "' where Cart_ID='" + Session["Cartid"] + "'";
        //    int i = obj.fun_Non_Query(m);
        //    if (i == 1)
        //    {
        //        Grid_bind();
        //        Label1.Text = "success";


        //        //string s = "select max(Cart_Id) from Table_Cart";
        //        //string cartid = obj.fun_Scalar(s);
        //        //int Cart_Id = 0;
        //        //if (cartid == "")
        //        //{
        //        //    Cart_Id = 1;
        //        //}
        //        //else
        //        //{
        //        //    int newcartid = Convert.ToInt32(cartid);
        //        //    Cart_Id = newcartid + 1;
        //        //}
        //        //string sel = "select Product_Price from Tab_Product where Product_Id=" + Session["sinproid"] + "";
        //        //string price = obj.fun_Scalar(sel);

        //        //Label1.Text = price;
        //    }
        //}



        //protected void LinkButton2_Command(object sender, CommandEventArgs e)
        //{
        //    int id = Convert.ToInt32(e.CommandArgument);
        //    string d = "delete from Table_Cart where Cart_ID='" + id + "'";
        //    int g = obj.fun_Non_Query(d);
        //    if (g == 1)
        //    {
        //        Grid_bind();
        //    }
        //}


    }
}