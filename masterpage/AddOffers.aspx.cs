using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AddOffers : System.Web.UI.Page
{
    //String comboID = "200";
    String category;
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
        SqlCommand cmd = new SqlCommand("select comboid from AddOffers1 ORDER BY comboid DESC", con);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        i++;
        txtcomboId.Text = i.ToString();
    }



    protected void btncsubmit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = "Data Source=LAPTOP-T5I17ICE;Initial Catalog=Canteen Management System;Integrated Security=True";
        con.Open();
        cmd.CommandText = "Insert into AddOffers1(comboname,category,foodname,foodbought,cost) values('" + txtcname.Text + "','" + DropDownList1.Text + "','" + DropDownList2.Text + "','" + DropDownList3.Text + "','" + txtcost.Text + "')";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();
        ClearTextBox();
        GenerateAutoID();
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Combo Pack Added !!');", true);
        
    }
        private void ClearTextBox()
        {
        DropDownList3.Items.Clear();
        txtcname.Text = "";
        txtcost.Text = "";
        }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList3.Items.Clear();
        SqlConnection con1 = new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        con1.ConnectionString = "Data Source=LAPTOP-T5I17ICE;Initial Catalog=Canteen Management System;Integrated Security=True ";
        con1.Open();
        String item = "select foodname from addfood where category='" + DropDownList1.SelectedValue.ToString() + "'";
        cmd1 = new SqlCommand(item, con1);
        SqlDataReader reader1 = cmd1.ExecuteReader();
        DropDownList2.Items.Clear();
        while (reader1.Read())
        {

            DropDownList2.Items.Add(new ListItem(reader1[0].ToString(), reader1[0].ToString()));
        }
        reader1.Close();

        category = DropDownList1.Text;
        if (category == "Starter")
        {
            if (DropDownList3.Items.Count == 0 && category == "Starter")
            {
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem("", ""));
                DropDownList3.Items.Insert(1, new ListItem("Vegies", "Vegies"));
                DropDownList3.Items.Insert(2, new ListItem("Chili Sauce", "Chili Sauce"));
                DropDownList3.Items.Insert(3, new ListItem("Manchow Soup", "Manchow Soup"));
                DropDownList3.Items.Insert(4, new ListItem("Schezwan Sausages", "Schezwan Sausages"));

            }

        }
        else if (category == "Main Course")
        {
            if (DropDownList3.Items.Count == 0 && category == "Main Course")
            {
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem("", ""));
                DropDownList3.Items.Insert(1, new ListItem("Rice", "Rice"));
                DropDownList3.Items.Insert(2, new ListItem("Roti", "Roti"));
                DropDownList3.Items.Insert(3, new ListItem("Tandoori Roti", "Tandoori Roti"));
                DropDownList3.Items.Insert(4, new ListItem("Jeera Rice", "Jeera Rice"));

            }

        }

        if (category == "Desserts")
        {
            if (DropDownList3.Items.Count == 0 && category == "Desserts")
            {
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem("", ""));
                DropDownList3.Items.Insert(1, new ListItem("Extra Chocolate", "Extra Chocolate"));
                DropDownList3.Items.Insert(2, new ListItem("Extra Vanilla", "Extra Vanilla"));
                DropDownList3.Items.Insert(3, new ListItem("Extra Strawberry", "Extra Strawberry"));
                DropDownList3.Items.Insert(4, new ListItem("Extra Peanut Butter", "Extra Peanut Butter"));

            }

        }
    }



    protected void txtcomboId_TextChanged(object sender, EventArgs e)
    {

    }
}

