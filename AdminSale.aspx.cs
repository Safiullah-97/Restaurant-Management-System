using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class AdminSale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



           



        }

        protected void click_Click(object sender, EventArgs e)
        {
            
            int imageLength = FileUpload1.PostedFile.ContentLength;
            byte[] picbyte = new byte[imageLength];
            FileUpload1.PostedFile.InputStream.Read(picbyte, 0, imageLength);


            string Connection = @"Data Source=DESKTOP-IT4SMQ7;Initial Catalog=RestaurantMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);

            string Add = "INSERT INTO Product VALUES (@product_name, @product_price, @Category,@Image)";

             SqlCommand com = new SqlCommand( Add, con);

            con.Open();
            com.Parameters.AddWithValue("@product_name", pname.Text);
            com.Parameters.AddWithValue("@product_price", pprice.Text);
            com.Parameters.AddWithValue("@Category", cat.SelectedItem.Value);
            com.Parameters.Add("@Image", SqlDbType.Image).Value = picbyte;

           
            
            com.ExecuteNonQuery();
            con.Close();

        }

        protected void Date_Click(object sender, EventArgs e)
        {
            string Connection = @"Data Source=DESKTOP-IT4SMQ7;Initial Catalog=RestaurantMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);

            SqlCommand com = new SqlCommand("SP_GET_SALES", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@FromDate", CalenderFrom.SelectedDate.ToString());
            com.Parameters.AddWithValue("@ToDate", CalenderTo.SelectedDate.ToString());

            con.Open();

            GridView1.DataSource = com.ExecuteReader();
            GridView1.DataBind();

           
            con.Close();
        }
    }
}