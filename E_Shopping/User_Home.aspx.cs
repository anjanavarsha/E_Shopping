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
    public partial class User_Home : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
           // Label3.Text = Session["userid"].ToString();
            
            if(!IsPostBack)
            {
                datalist_bind();
            }
        
        }
        public void datalist_bind()
        {
            string s = "select * from Tab_Category";
            DataSet ds = obj.fun_ExecuteAdapter(s);
           DataList1.DataSource = ds;
            DataList1.DataBind();
        }
        protected void ImageButton1_Command1(object sender, CommandEventArgs e)
        {
            Session["cateid"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("User_Product_View.aspx");
        }
    }
}