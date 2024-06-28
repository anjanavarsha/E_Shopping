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
    public partial class Edit_Product_Details : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {



                string s = "select * from Tab_Product where Product_Id=" + Session["uid"] + " ";
                SqlDataReader dr = obj.fun_ExeReader(s);
                while (dr.Read())
                {
                    TextBox1.Text = dr["Product_Name"].ToString();
                    Image1.ImageUrl = dr["Product_Image"].ToString();
                    TextBox2.Text = dr["Product_Price"].ToString();
                    TextBox3.Text = dr["Product_Description"].ToString();
                    TextBox4.Text = dr["Product_Stock"].ToString();
                    TextBox6.Text = dr["Product_Status"].ToString();
                }

            }
        }

        //    protected void Page_Load(object sender, EventArgs e)
        //    {

        //        grid_bind();


        //    }
        //    public void grid_bind()
        //    {
        //        string s = "select * from Tab_Product";
        //        DataSet ds = obj.fun_ExecuteAdapter(s);
        //        GridView1.DataSource = ds;
        //        GridView1.DataBind();
        //    }

        //    protected void Button1_Click(object sender, EventArgs e)
        //    {
        //        string p = "~/Photo/" + FileUpload1.FileName;
        //        FileUpload1.SaveAs(MapPath(p));
        //        string update = "update Tab_Product set Product_Name='" + TextBox1.Text + "',Product_Image='" + p + "',Product_Price=" + TextBox2.Text + ",Product_Description='" + TextBox3.Text + "',Product_Stock='" + TextBox4.Text + "',Product_Status='" + DropDownList1.SelectedItem.Text + "' where Product_Id=" + Session["puid"] + "";
        //        int i = obj.fun_Non_Query(update);
        //        if (i == 1)
        //        {
        //            Label7.Text = "updated";
        //        }

        //    }


        //    protected void LinkButton2_Command(object sender, CommandEventArgs e)
        //    {
        //        //Response.Redirect("Edit_Product_Details");
        //        //Panel1.Visible = true;
        //        //int pid = Convert.ToInt32(e.CommandArgument);
        //        //Session["productid"] = pid;
        //        //string s = "select * from Tab_Product where Product_Id=" + pid + " ";
        //        //SqlDataReader dr = obj.fun_ExeReader(s);
        //        //while (dr.Read())
        //        //{
        //        //    TextBox1.Text = dr["Product_Name"].ToString();
        //        //    Image1.ImageUrl = dr["Product_Image"].ToString();
        //        //    TextBox2.Text = dr["Product_Price"].ToString();
        //        //    TextBox3.Text = dr["Product_Description"].ToString();
        //        //    TextBox4.Text = dr["Product_Stock"].ToString();
        //        //    TextBox6.Text = dr["Product_Status"].ToString();
        //        //}

        //    }

        //    protected void LinkButton3_Command(object sender, CommandEventArgs e)
        //    {
        //        int pid1 = Convert.ToInt32(e.CommandArgument);
        //        Session["puid"] = pid1;
        //        string sel = "select Product_Status from Tab_Product where Product_id=" + pid1 + " ";
        //        string s = obj.fun_Scalar(sel);
        //        if (s == "Available")
        //        {
        //            string u = "update Tab_Product set Product_Status='Un Available'  where Product_id=" + pid1 + "";
        //            int i = obj.fun_Non_Query(u);
        //            grid_bind();
        //        }
        //        else
        //        {
        //            string d = "update Tab_Product set Product_Status='Un Available' where Product_Id=" + pid1 + "";
        //            int j = obj.fun_Non_Query(d);
        //            grid_bind();
        //        }

        //    }

        //    protected void LinkButton5_Command(object sender, CommandEventArgs e)
        //    {
        //        Panel1.Visible = true;
        //        int pid = Convert.ToInt32(e.CommandArgument);
        //        Session["productid"] = pid;
        //        string s = "select * from Tab_Product where Product_Id=" + pid + " ";
        //        SqlDataReader dr = obj.fun_ExeReader(s);
        //        while (dr.Read())
        //        {
        //            TextBox1.Text = dr["Product_Name"].ToString();
        //            Image1.ImageUrl = dr["Product_Image"].ToString();
        //            TextBox2.Text = dr["Product_Price"].ToString();
        //            TextBox3.Text = dr["Product_Description"].ToString();
        //            TextBox4.Text = dr["Product_Stock"].ToString();
        //            TextBox6.Text = dr["Product_Status"].ToString();
        //        }


        //    }
        //}
    }
}