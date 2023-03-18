﻿using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Registration
{
    public partial class instock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }





        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void btn_view_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm3.aspx");
        }

        protected void btn_view_Click1(object sender, EventArgs e)
        {

            // Retrieve the connection string from web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Create a new MySqlConnection using the connection string
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Open the connection to the database
                connection.Open();

                // Create the SQL query based on the current month
                string query;
                if (ddl_Month.SelectedValue == "1") // Januarys
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_jan;";
                }
                else if (ddl_Month.SelectedValue == "2") // February
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_feb;";
                }
                else if (ddl_Month.SelectedValue == "3") // March
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_mar;";
                }
                else if (ddl_Month.SelectedValue == "4") // April
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_apr;";
                }
                else if (ddl_Month.SelectedValue == "5") // May
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_may;";
                }
                else if (ddl_Month.SelectedValue == "6") // June
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_june;";
                }
                else if (ddl_Month.SelectedValue == "7") // July
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_jul;";
                }
                else if (ddl_Month.SelectedValue == "8") // August
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_aug;";
                }
                else if (ddl_Month.SelectedValue == "9") // September
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_sep;";
                }
                else if (ddl_Month.SelectedValue == "10") // October
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_oct;";
                }
                else if (ddl_Month.SelectedValue == "11") // November
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_nov;";
                }
                else // December
                {
                    query = "SELECT item_name,company_name,brand_name,quantity,invoice_number,initial_stock,date FROM items_in_dec;";
                }

                MySqlCommand command = new MySqlCommand(query, connection);

                // Create a DataTable to hold the results of the query
                DataTable dataTable = new DataTable();

                // Use a MySqlDataAdapter to fill the DataTable with the results of the query
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Bind the DataTable to the GridView control
                GridView1.DataSource = dataTable;
                GridView1.DataBind();

                // Close the connection to the database
                connection.Close();
            }
            // Execute the SQL query using the appropriate database connection

        }
    }
}