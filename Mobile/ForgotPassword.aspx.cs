using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileSystem.Mobile
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        String password;
        String mail;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string str = null;
            SqlConnection con1 = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            con1.ConnectionString = "Data Source=LAPTOP-T5I17ICE;Initial Catalog=Canteen Management System;Integrated Security=True";
            con1.Open();
            string strnew = "select count(*) from Student_Registration where email ='" + TextBox1.Text + "'";
            cmd = new SqlCommand(strnew, con1);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                SqlConnection con = new SqlConnection();
                SqlCommand cmd1 = new SqlCommand();
                con.ConnectionString = "Data Source=LAPTOP-T5I17ICE;Initial Catalog=Canteen Management System;Integrated Security=True";
                con.Open();
                String name = "select password,email from Student_Registration where email='" + TextBox1.Text + "'";

                cmd1 = new SqlCommand(name, con);

                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    password = reader["password"].ToString();
                    mail = reader["email"].ToString();

                }
                reader.Close();
                con.Close();
                MailMessage message = new MailMessage();
                message.Subject = "Password Request";
                message.Body = "Hello,your password is: " + password + "\n Regards,\nRuia College.";
                message.From = new MailAddress("Ravidwivedi1999@gmail.com");

                // Email Address from where you send the mail
                var fromAddress = "Ravidwivedi1999@gmail.com";

                //Password of your mail address
                const string fromPassword = "Rd_star07";
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                    smtp.Timeout = 20000;
                }


                var to = mail;
                message.To.Add(to);



                // Passing values to smtp object        
                smtp.Send(message);
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Check your email');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Username is not valid');", true);

            }
            //  clear();
            con1.Close();

        }
    }
}