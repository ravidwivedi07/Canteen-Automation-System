using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileSystem.Mobile
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sdt = null;
            con.ConnectionString = "Data Source=LAPTOP-T5I17ICE;Initial Catalog=Canteen Management System;Integrated Security=True";
            con.Open();
            sdt = new SqlDataAdapter("select category,foodname,amount from addfood ", con);
            DataSet ds = new DataSet();
            sdt.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}