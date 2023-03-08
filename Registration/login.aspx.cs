using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using MySql.Data.MySqlClient;

namespace Registration
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string Loginpage(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=stock;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username=@username AND password=@password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return "success";
            }
            else
            {
                return "failure";
            }
        }

        protected void btn_login_Click(object sender, EventArgs e )
        {
            string username =inputUsername.Text;
            string password = inputPassword.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=stock;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username=@username AND password=@password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string redirectUrl = "Additems.aspx";
                Response.Redirect(redirectUrl);
                
            }
            else
            {
                string redirectUrl = "login.aspx";
                Response.Redirect(redirectUrl);
            }
        }
    }
}
