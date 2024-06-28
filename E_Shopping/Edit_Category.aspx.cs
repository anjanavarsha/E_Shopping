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
    public partial class Edit_Category : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            

                grid_bind();


            }
            public void grid_bind()
            {
                string s = "select * from Tab_Category";
                DataSet ds = obj.fun_ExecuteAdapter(s);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
           

        protected void Button1_Click1(object sender, EventArgs e)
        {
            {
                
                               
                string p = "~/Photo/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(p));
                string update = "update Tab_Category set Category_Name='" + TextBox1.Text + "',Category_Image='" + p + "',Category_Description='" + TextBox2.Text + "',Category_Status='" + DropDownList1.SelectedItem.Text+ "' where Category_Id="+Session["uid"]+"";
                int i = obj.fun_Non_Query(update);
                if(i==1)
                {
                    Label5.Text = "updated";
                }


            }


        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            int id = Convert.ToInt32(e.CommandArgument);
            Session["uid"] = id;
            string s = "select * from Tab_Category where Category_id="+id+" ";
            SqlDataReader dr = obj.fun_ExeReader(s);
            while (dr.Read())
            {

                TextBox1.Text = dr["Category_Name"].ToString();
                Image1.ImageUrl = dr["Category_Image"].ToString();
                TextBox2.Text = dr["Category_Description"].ToString();
                TextBox3.Text = dr["Category_Status"].ToString();
                
            }
        }
        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            int id1 = Convert.ToInt32(e.CommandArgument);
            Session["uid"] = id1;
            string sel = "select Category_Status from Tab_Category where Category_id=" + id1 + " ";
            string s = obj.fun_Scalar(sel);
            if (s == "Available")
            {
                string u = "update Tab_Category set Category_Status='Un Available'  where Category_id=" + id1 + "";
                int i = obj.fun_Non_Query(u);
                grid_bind();
            }
            else
            {
                string d = "update Tab_Category set Category_Status='Un Available' where Category_Id=" + id1 + "";
                int j = obj.fun_Non_Query(d);
                grid_bind();

            }

            }
    }
}