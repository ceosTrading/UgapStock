using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Registration
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidateUser(object sender, EventArgs e)
        {
            string Uname = txtUsername.Text;
            string psswrd = txtPassword.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT * FROM users where username = @username AND `password` = @password";
            MySqlCommand mycommand = new MySqlCommand(query, connection);
            mycommand.Parameters.AddWithValue("@username", Uname);
            mycommand.Parameters.AddWithValue("@password", psswrd);

            {
                mycommand.Connection = connection;
                    connection.Open();
                    MySqlDataReader reader = mycommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader.GetString(1);
                    string password = reader.GetString(2);
                        ListItem item = new ListItem(name, password.ToString());
                    //ddl_products.Items.Add(item);
                    Response.Redirect("~/WELCOME !!!.aspx");
                }

                reader.Close();
                lblMessage.Text = "Incorrect Username Or Password !!";
                }

            }
        
    }
}