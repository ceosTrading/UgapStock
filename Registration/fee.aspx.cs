using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Text.RegularExpressions;



namespace Registration
{
    public partial class fee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=students");

            connection.Open();
            string selectmem = "SELECT MEMBERSHIP_NO FROM payments WHERE MEMBERSHIP_NO ='" + txt_id.Text + "'";


            MySqlCommand mycommand = new MySqlCommand(selectmem, connection);
            MySqlDataReader reader = mycommand.ExecuteReader();
            mycommand.CommandText = selectmem;

            //mycommand.ExecuteNonQuery();
            //mycommand.Connection = connection;

            if (reader.Read())
            {
                string check = reader.GetString("MEMBERSHIP_NO");



                connection.Close();



                if (check == "")
                {
                    Label1.Text = "Student Not Found";

                }

                else
                {

                    string id = txt_id.Text;


                    //MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=students");

                    connection.Open();
                    string date = DateTime.Now.ToString("MM/dd/yyyy");
                    string insert_query = "UPDATE payments SET LAST_DATE ='" + date + "' WHERE MEMBERSHIP_NO = '" + txt_id.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(insert_query, connection);

                    cmd.CommandText = insert_query;
                    cmd.ExecuteNonQuery();
                    cmd.Connection = connection;
                    connection.Close();

                    if (DropDownList1.SelectedValue != "")
                    {
                        //string id = txt_id.Text;
                        string ubetatta = DropDownList1.SelectedValue;
                        var StringToBeRepalced = ubetatta;
                        var StringWithoutSpclCharac = Regex.Replace(StringToBeRepalced, @"[^0-9a-zA-Z\._]", "");


                        //MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=students");

                        connection.Open();
                        //string date = DateTime.Now.ToString("MM/dd/yyyy");
                        string ube_amma = "UPDATE payments SET " + StringWithoutSpclCharac + " ='" + date + "' WHERE MEMBERSHIP_NO = '" + txt_id.Text + "'";

                        MySqlCommand cmdd = new MySqlCommand(ube_amma, connection);

                        cmdd.CommandText = ube_amma;
                        cmdd.ExecuteNonQuery();
                        cmdd.Connection = connection;
                        connection.Close();
                        Label1.Text = "Paid Success";

                    }

                }
            }
            else
            {
                connection.Close();
                Label1.Text = "";
                connection.Open();
                string insert = "INSERT INTO payments (MEMBERSHIP_NO) VALUES('" + txt_id.Text + "')";

                MySqlCommand commd = new MySqlCommand(insert, connection);

                commd.CommandText = insert;
                commd.ExecuteNonQuery();
                commd.Connection = connection;
                connection.Close();

                //string id = txt_id.Text;
                string ubetatta = DropDownList1.SelectedValue;
                var StringToBeRepalced = ubetatta;
                var StringWithoutSpclCharac = Regex.Replace(StringToBeRepalced, @"[^0-9a-zA-Z\._]", "");


                //MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=students");

                connection.Open();
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                string ube_amma = "UPDATE payments SET " + StringWithoutSpclCharac + " ='" + date + "' WHERE MEMBERSHIP_NO = '" + txt_id.Text + "'";

                MySqlCommand cmdd = new MySqlCommand(ube_amma, connection);

                cmdd.CommandText = ube_amma;
                cmdd.ExecuteNonQuery();
                cmdd.Connection = connection;
                connection.Close();
                Label1.Text = "Paid Success";
            }
        }

        protected void txt_id_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=students");

            connection.Open();
            string selectmem = "SELECT NAME FROM personal_info WHERE MEMBERSHIP_NO ='" + txt_id.Text + "'";


            MySqlCommand mycommand = new MySqlCommand(selectmem, connection);
            MySqlDataReader reader = mycommand.ExecuteReader();
            mycommand.CommandText = selectmem;

            //mycommand.ExecuteNonQuery();
            //mycommand.Connection = connection;

            if (reader.Read())
            {
                string name = reader.GetString("NAME");
                Label1.Text = "";
                Label2.Text = name;

                connection.Close();
                
            }
            else
            {
                reader.Close();
                string selectname = "SELECT NAME FROM personal_info WHERE MEMBERSHIP_NO ='" + txt_id.Text + "'";


                MySqlCommand myname = new MySqlCommand(selectname, connection);
                MySqlDataReader myreader = mycommand.ExecuteReader();
                mycommand.CommandText = selectname;

                //mycommand.ExecuteNonQuery();
                //mycommand.Connection = connection;

                if (myreader.Read())
                {
                    string name = reader.GetString("NAME");
                    connection.Open();
                    string insert = "INSERT INTO payments (MEMBERSHIP_NO) VALUES('" + txt_id.Text + "')";

                    MySqlCommand commd = new MySqlCommand(insert, connection);

                    commd.CommandText = insert;
                    commd.ExecuteNonQuery();
                    commd.Connection = connection;
                    connection.Close();
                    Label1.Text = "Paid Success";



                }




                Label2.Text = "";
                Label1.Text = "Plese Enter Vaild ID";
            }
            }
    }
}