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
    public partial class Admin_Category_View : System.Web.UI.Page
    {
        ConnectionCls obj=new ConnectionCls();
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

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("Edit_Category.aspx");

        }
    }
}