using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Grid();

            string Connection = @"Data Source=DESKTOP-IT4SMQ7;Initial Catalog=RestaurantMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);
            HttpContext.Current.Server.MapPath("~//images");



        }

        protected void btn1_Click(object sender, EventArgs e)
        {
           



        }

    

        protected void btn1_click(object sender, EventArgs e)
        {

        }

        public void Load_Grid()
        {
            string Connection = @"Data Source=DESKTOP-IT4SMQ7;Initial Catalog=RestaurantMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);
        
            string query = "SELECT Image_data from Images";
            SqlCommand com = new SqlCommand(query, con);
          
            con.Open();
    
           

            SqlDataReader SQLDR = com.ExecuteReader();
            while(SQLDR.Read())
            {

                ImageButton i1 = new ImageButton();
                
                i1.Height = 143;
                i1.Width = 136;
                byte[] bytes = (byte[])SQLDR["Image_data"];
                string strBase64 = Convert.ToBase64String(bytes);
                i1.ImageUrl = "data:Image/png;base64," + strBase64;
                this.placeHolder1.Controls.Add(i1);
            }
            
           
      
            con.Close();



            //byte[] images = (byte[])(rdr["images"]);
            //string Images = Convert.ToBase64String(images);
            //Image.ImageUrl = String.Format("data:image/jpg;base64,{0}", Images);
            //Image1.ImageUrl = "images/" + Convert.ToString(rdr["images"]);
            //Image1.ImageUrl = "~/images/" + Convert.ToString(rdr["imagepath"]);
            //com.ExecuteReader();
            //con.Close();

            //GridView1.DataSource = rdr;
            //GridView1.DataBind();


        }

    

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            
        }
    }
 }
