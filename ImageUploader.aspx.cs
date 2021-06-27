using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication8
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            int imageLength = FileUpload2.PostedFile.ContentLength;
            byte[] picbyte = new byte[imageLength];
            FileUpload2.PostedFile.InputStream.Read(picbyte, 0, imageLength);



            string Connection = @"Data Source=DESKTOP-IT4SMQ7;Initial Catalog=RestaurantMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);

            string query = "Insert into Images values('Tikka',@Image)";
            SqlCommand com = new SqlCommand(query, con);

            com.Parameters.Add("@Image", SqlDbType.Image).Value = picbyte;

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
    }
