using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class InventoryDetails : System.Web.UI.Page
{
    String productID = "Product";
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            GenerateAutoID();
        }
    }
    private void GenerateAutoID()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=LAPTOP-T5I17ICE;Initial Catalog=Canteen Management System;Integrated Security=True";
        con.Open();
        SqlCommand cmd = new SqlCommand("select max(productid) from Inventory_details",con);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        i++;
        txtproid.Text = i.ToString();
    }
    protected void btnprosubmit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = "Data Source=LAPTOP-T5I17ICE;Initial Catalog=Canteen Management System;Integrated Security=True";
        con.Open();
        cmd.CommandText = "Insert into Inventory_details(productname,quantity) values('" +  txtproname.Text + "','" + txtqnty.Text + "')";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();
        GenerateAutoID();
        ClearTextBox();
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data Added !!');", true);
    }
    private void ClearTextBox()
    {
        txtproname.Text = "";
        txtqnty.Text = "";
    }

    
}