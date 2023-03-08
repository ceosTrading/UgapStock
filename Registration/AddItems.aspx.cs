﻿using MySql.Data.MySqlClient;
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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                string query = "SELECT id,item_name FROM items_in;";
                MySqlCommand command = new MySqlCommand(query);
                using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    command.Connection = connection;
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        ListItem item = new ListItem(name, id.ToString());
                        ddl_products.Items.Add(item);
                    }

                    reader.Close();
                }




            }
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            int month = DateTime.Now.Month;
            string date;
            if (month == 1) // January
            {
                date = "items_in_jan";
            }
            else if (month == 2) // February
            {
                date = "items_in_feb";
            }
            else if (month == 3) // March
            {
                date = "items_in_mar";
            }
            else if (month == 4) // April
            {
                date = "items_in_apr";
            }
            else if (month == 5) // May
            {
                date = "items_in_may";
            }
            else if (month == 6) // June
            {
                date = "items_in_june";
            }
            else if (month == 7) // July
            {
                date = "items_in_july";
            }
            else if (month == 8) // August
            {
                date = "items_in_aug";
            }
            else if (month == 9) // September
            {
                date = "items_in_sep";
            }
            else if (month == 10) // October
            {
                date = "items_in_oct";
            }
            else if (month == 11) // November
            {
                date = "items_in_nov";
            }
            else // December
            {
                date = "items_in_dec";
            }


            string itemname = ddl_products.SelectedItem.Text;
            string check = "SELECT initial_stock,date FROM "+date+ " WHERE item_name = @SelectedName ORDER BY date DESC LIMIT 1";
            int output;
            MySqlCommand mycommand = new MySqlCommand(check, connection);
            mycommand.Parameters.AddWithValue("@SelectedName", itemname);

            try
            {
                // Open the connection and execute the command
                connection.Open();
                output = (int)mycommand.ExecuteScalar();
                TextBox1.Text = output.ToString();

                mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Display an error message
                lbl_message.Text = "Error inserting data: " + ex.Message;
            }
            finally
            {
                // Close the connection

                connection.Close();
            }






            // Get the values from the textboxes
            string productName = ddl_products.SelectedItem.Text;
            string companyName = txt_compName.Text;
            string brandName = txt_brandName.Text;
            string invoiceNumber = txt_invNum.Text;
            string valu = txt_quantity.Text;
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(txt_quantity.Text);
            int sum = num1 + num2;


            int quantity = sum;

            //string check = "";

            // Create a connection to the MySQL database using the connection string from the web.config file
            //string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //MySqlConnection connection = new MySqlConnection(connectionString);


            // ----------------------------------------------------------------
            // Get the current month
            //int month = DateTime.Now.Month;

            // Create the SQL query based on the current month
            string query;
if (month == 1) // January
{
                query = "INSERT INTO items_in_jan (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
else if (month == 2) // February
{
                query = "INSERT INTO items_in_feb (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else if (month == 3) // March
{
                query = "INSERT INTO items_in_mar (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else if (month == 4) // April
{
                query = "INSERT INTO items_in_apr (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else if (month == 5) // May
{
                query = "INSERT INTO items_in_may (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else if (month == 6) // June
{
                query = "INSERT INTO items_in_june (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else if (month == 7) // July
{
                query = "INSERT INTO items_in_jul (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else if (month == 8) // August
{
                query = "INSERT INTO items_in_aug (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else if (month == 9) // September
{
                query = "INSERT INTO items_in_sep (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else if (month == 10) // October
{
                query = "INSERT INTO items_in_oct (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else if (month == 11) // November
{
                query = "INSERT INTO items_in_nov (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }
            else // December
{
                query = "INSERT INTO items_in_dec (item_name, company_name, brand_name, invoice_number, quantity,initial_stock,date) VALUES (@item_name, @company_name, @brand_name, @invoice_number, @quantity, @stock, @date);";
            }

            // Execute the SQL query using the appropriate database connection

            //-----------------------------------------------------------------


            // Create a command object to insert the data into the table

            //string query = "INSERT INTO items_in (product_name, company_name, brand_name, invoice_number, quantity) VALUES (@product_name, @company_name, @brand_name, @invoice_number, @quantity);";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@item_name", productName);
            command.Parameters.AddWithValue("@company_name", companyName);
            command.Parameters.AddWithValue("@brand_name", brandName);
            command.Parameters.AddWithValue("@invoice_number", invoiceNumber);
            command.Parameters.AddWithValue("@quantity", valu);
            command.Parameters.AddWithValue("@stock", quantity);
            command.Parameters.AddWithValue("@date", DateTime.Now);


            try
            {
                // Open the connection and execute the command
                connection.Open();
                command.ExecuteNonQuery();

                // Clear the textboxes
                ddl_products.SelectedIndex = 0;
                txt_compName.Text = "";
                txt_brandName.Text = "";
                txt_invNum.Text = "";
                txt_quantity.Text = "";

                // Display a success message
                lbl_message.Text = "Data inserted successfully.";
            }
            catch (Exception ex)
            {
                // Display an error message
                lbl_message.Text = "Error inserting data: " + ex.Message;
            }
            finally
            {
                // Close the connection
                connection.Close();
            }

        }

       

        protected void btn_view_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            
        }

        protected void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_id_TextChanged(object sender, EventArgs e)
        {

           

        }

        protected void btn_pay_Click(object sender, EventArgs e)
        {
            Response.Redirect("fee.aspx");
        }

        protected void btn_viewst_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}