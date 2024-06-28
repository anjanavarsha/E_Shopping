using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;using System.Data.SqlClient;

namespace E_Shopping
{
    public partial class View_Cart : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        int cid;
        int cqu;
        int cto;
        string cst;
        int pid;
        int uid;
        
        int gt = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid_view();
            }

            
        }
        public void grid_view()
        {
           string y= "select Tab_Product.Product_Image,Tab_Product.Product_Name,Tab_Product.Product_Description,Table_Cart.Cart_ID,Table_Cart.Cart_Quantity,Table_Cart.Total_Price,Table_Cart.Status from Tab_Product join Table_Cart on Tab_Product.Product_Id=Table_Cart.Product_Id where User_Id='" + Session["userid"] + "'";
            //string y = "select t1.*, t2.* from Tab_Product t1 join Table_Cart t2 on t2.Product_Id = t1.Product_Id where User_Id=" + Session["userid"] + "";
            DataSet ds = obj.fun_ExecuteAdapter(y);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            Session["cartid"] = Convert.ToInt32(e.CommandArgument);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string t = "select t2.Product_Price from Tab_Product t2 join Table_Cart t1 on t1.Product_Id = t2.Product_Id where t1.Cart_ID='" + Session["cartid"] + "'";
            string f = obj.fun_Scalar(t);
            int q = Convert.ToInt32(TextBox1.Text);
            int p = Convert.ToInt32(f);
            int t_price = q * p;
            string m = "update Table_Cart set Cart_Quantity='" + TextBox1.Text + "',Total_Price='" + t_price + "' where Cart_ID='" + Session["cartid"] + "' ";
            int i = obj.fun_Non_Query(m);
            if (i == 1)
            {
                grid_view();
                Label2.Visible = true;
                Label2.Text = "success";
            }

        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            string del = "delete from Table_Cart where Cart_ID=" + id + "";
            int i = obj.fun_Non_Query(del);
            if (i == 1)
            {
                grid_view();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string mx = "select Max(Cart_ID) from Table_Cart";
            string m = obj.fun_Scalar(mx);
            int max = Convert.ToInt32(m);

            for (int i = 1; i <= max; i++)
            {
                string uids = "select User_Id from Table_Cart where cart_ID=" + i + " ";
                string st = obj.fun_Scalar(uids);
                int q = Convert.ToInt32(st);
                int ids = Convert.ToInt32(Session["userid"]);
                if (q == ids)
                {
                    string cat = "select * from Table_Cart where Cart_ID=" + i + "";
                    SqlDataReader dr = obj.fun_ExeReader(cat);
                    while (dr.Read())
                    {


                     
                        cid = Convert.ToInt32(dr["Cart_ID"].ToString());
                        cqu = Convert.ToInt32(dr["Cart_Quantity"].ToString());
                        cto = Convert.ToInt32(dr["Total_Price"].ToString());
                        cst = dr["Status"].ToString();
                        pid = Convert.ToInt32(dr["Product_Id"].ToString());
                        uid = Convert.ToInt32(dr["User_Id"].ToString());
                    }
                    gt = gt + cto;
                    string ins = "insert Into Tab_Order values ('notpaid'," + cid + "," + cqu + "," + cto + ",'" + cst + "'," + pid + "," + uid + ")";
                    int j = obj.fun_Non_Query(ins);
                    string bin = "insert into Tab_Bill values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','unpaid'," + uid + "," + gt + ")";
                    int k = obj.fun_Non_Query(bin);

                    if (k != 0)
                    {
                        string del = "truncate table Table_Cart";
                        int l = obj.fun_Non_Query(del);
                    }
                    Response.Redirect("User_View_Bill.aspx");



                }


            }


        }
    }
}