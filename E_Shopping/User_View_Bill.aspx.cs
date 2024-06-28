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
    public partial class User_View_Bill : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string sel = "select t1.*,t2.* from Tab_Product t1 join Tab_Order t2 on t1.Product_Id=t2.Product_Id where Order_Status='notpaid' and User_Id=" + Session["userid"] + " ";
            string sel = "select Tab_Product.Product_Name,Tab_Product.Product_Image,Tab_Product.Product_Price,Tab_Product.Product_Status,Tab_Order.Order_Status,Tab_Order.Cart_Quantity,Tab_Order.Total_Price from Tab_Product join Tab_Order on Tab_Product.Product_Id=Tab_Order.Product_Id where Order_Status='notpaid' and User_Id=" + Session["userid"] + " ";
            DataSet ds = obj.fun_ExecuteAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            string st = "select * from Tab_Bill where User_Id=" + Session["userid"] + " and Bill_Status='unpaid'";
            SqlDataReader dr = obj.fun_ExeReader(st);
            while (dr.Read())
            {
                Label5.Text = dr["Bill_Id"].ToString();
                Label6.Text = dr["Bill_Date"].ToString();
                Label7.Text = dr["Grand_Total"].ToString();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Checkbalance.ServiceClient obj1 = new Checkbalance.ServiceClient();
            string bal = obj1.BalanceCheck(TextBox1.Text);
            int ba = Convert.ToInt32(bal);
            Label3.Text = bal;

            string st = "select Grand_Total from Tab_Bill where User_Id=" + Session["userid"] + "";
            string t = obj.fun_Scalar(st);
            int gt = Convert.ToInt32(t);



            if (ba > gt)
            {
                string cup = "update Tab_Order set Status='unavilable' , Order_Status='payed' where User_Id=" + Session["userid"] + "";
                int i = obj.fun_Non_Query(cup);

                string bup = "update Tab_Bill set Bill_Status='payed' where  User_Id=" + Session["userid"] + " ";
                int j = obj.fun_Non_Query(bup);

                string uac = "update Table_Account set Balance_Amount=" + (ba - gt) + " where User_Id=" + Session["userid"] + "";
                int k = obj.fun_Non_Query(uac);

                Label10.Text = "payed";
            }
            else
            {
                Label10.Text = "Insufficient Balance";
            }
        }


        
    }
    
}