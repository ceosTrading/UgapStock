using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Registration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root; password=admin;database=studentdb");
            
            connection.Open();
            string insert_query = "INSERT INTO student (first_name,last_name,email,phone_number,studentid) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            
            MySqlCommand cmd = new MySqlCommand(insert_query, connection);
            
            cmd.CommandText = insert_query;
            cmd.ExecuteNonQuery();
            cmd.Connection = connection;
            connection.Close();





            Label2.Text = "Student Registration Successfull !";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           MySqlConnection connection = new MySqlConnection("server=localhost;user id=root; password=admin;database=studentdb");
           string searchstudentidToDelete = TextBox5.Text;
           string delete_query = "DELETE FROM student WHERE studentid = '" + searchstudentidToDelete + "'";

           
            MySqlCommand cmd = new MySqlCommand(delete_query, connection);
            
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();


            Label2.Text = "Student Delete Successfull !";
           
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }


        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root; password=admin;database=studentdb");
            string searchstudentidToUpdate = TextBox5.Text;
            string update_query = "UPDATE student SET first_name = '"+TextBox1.Text+ "',last_name = '" + TextBox2.Text + "',email = '" + TextBox3.Text + "',phone_number = '" + TextBox4.Text + "' WHERE studentid = '" + TextBox5.Text + "'";
            MySqlCommand cmd = new MySqlCommand(update_query, connection);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            //Label6.Text = "Student Updated Successfull !";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }
    }
}