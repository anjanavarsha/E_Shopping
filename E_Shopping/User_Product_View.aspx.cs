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
    public partial class User_Product_View : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                datalist_bind();
            }
        }
        public void datalist_bind()
        {
            string s = "select * from Tab_Product where Category_Id=" + Session["cateid"] + "";
            DataSet ds = obj.fun_ExecuteAdapter(s);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        

        protected void ImageButton1_Command1(object sender, CommandEventArgs e)
        {
            Session["sinproid"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("User_Single_Product_View.aspx");

        }
    }
}