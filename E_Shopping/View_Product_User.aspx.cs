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
    public partial class View_Product_User : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string s = "select * from Tab_Product where Category_id =" + Session["uid"] + "";
            //int i = obj.fun_Non_Query(s);
            datalist_bind();
        }
        public void datalist_bind()
        {
            
            string s = "select * from Tab_Product where Category_Id="+Session["uid"]+"";
            DataSet ds = obj.fun_ExecuteAdapter(s);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}