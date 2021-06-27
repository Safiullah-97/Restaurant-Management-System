using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class LoginDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            
            string Email = id.Text;
            string Pass = pass.Text;

            string Connection = @"Data Source=DESKTOP-IT4SMQ7;Initial Catalog=RestaurantMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);

            string query = "SELECT Role from [User_detail] where user_email=@email AND user_password=@password";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@email", Email);
            com.Parameters.AddWithValue("@password", Pass);

            con.Open();

            string Role = "";


            if (com.ExecuteScalar()!=null)
            {
                Role = com.ExecuteScalar().ToString();
            }

            if (Role == "Admin")
            {
                Response.Redirect("AdminSale.aspx");

            }
            else if (Email ==" " && Pass == " ") {
                Response.Write("You should Enter Id and password");
                Response.Redirect("WebFrom7.aspx");
            }

            else if (Role == "User")
            {
                Response.Redirect("sale.aspx");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Login Unsuccessful')</script>");
            }

            con.Close();
        }
    }
}