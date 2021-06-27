using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class Invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Grid();
        }

        public void Load_Grid()
        {
            string Connection = @"Data Source=DESKTOP-IT4SMQ7;Initial Catalog=RestaurantMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);

            string query = "SELECT * from Invoice";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            GridView1.DataSource = com.ExecuteReader();
            GridView1.DataBind();
            con.Close();

        }

    }
}