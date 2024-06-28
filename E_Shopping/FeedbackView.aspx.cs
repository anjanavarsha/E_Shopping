using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace E_Shopping
{
    public partial class FeedbackView : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid_bind();
                
            }
        }
        public void grid_bind()
        {
            string s = "select * from Tab_Feedback where Status ='pending'";
            DataSet ds = obj.fun_ExecuteAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)
        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            SendEmail2("Anjana", "anjana3906@gmail.com", "mujg aqls htiq ygvf", "'" + Label5.Text + "'", " " + Label7.Text + " ", "feedback Reply", "'" + TextBox1.Text + "'");
            string s1 = "update Tab_Feedback set Replay='" + TextBox1.Text + "',Status='Sent' where FId='" + Session["feedbackid"] + "'";
            int u = obj.fun_Non_Query(s1);
            if (u == 1)
            {
                grid_bind();
                Panel1.Visible = false;
            }
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            int fid = Convert.ToInt32(e.CommandArgument);
            Session["feedbackid"] = fid;
            string s = "select * from Tab_Feedback where FId=" + fid + " ";
            string sel = "select Tab_User_Registration.User_Name,Tab_User_Registration.User_Email,Tab_Feedback.Replay from Tab_Feedback join Tab_User_Registration on Tab_Feedback.User_Id=Tab_User_Registration.User_Id";
            SqlDataReader dr = obj.fun_ExeReader(sel);
            while (dr.Read())
            {
                Label5.Text = dr["User_Name"].ToString();
               
                Label7.Text = dr["User_Email"].ToString();
               
            }
        }
    }
}