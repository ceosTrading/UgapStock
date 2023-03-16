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
    public partial class stockout : System.Web.UI.Page
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
            try
            {
                connection.Open();
                string check = "SELECT initial_stock,date FROM " + date + " WHERE item_name = @SelectedName ORDER BY date DESC LIMIT 1";
                int output;
                MySqlCommand mycommand = new MySqlCommand(check, connection);
                mycommand.Parameters.AddWithValue("@SelectedName", itemname);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mycommand);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count == 0)
                {

                    lbl_message.Text = "There Is No Items In Stock";
                    connection.Close();
                }
                else
                {

                    DataRow row = dataSet.Tables[0].Rows[0];




                    string column1Value = row["initial_stock"].ToString(); // Access column by name
                    int c1Value = int.Parse(column1Value);
                    int numm2 = int.Parse(txt_quantity.Text);
                    int summery = c1Value - numm2;
                    int total = summery;
                    TextBox1.Text = summery.ToString();
                    // Get the values from the textboxes
                    string productName = ddl_products.SelectedItem.Text;
                    string companyName = txt_compName.Text;
                    string brandName = txt_brandName.Text;
                    string invoiceNumber = txt_invNum.Text;
                    string valu = txt_quantity.Text;
                    int num1 = int.Parse(TextBox1.Text);
                    int num2 = int.Parse(txt_quantity.Text);
                    int quantity = num1;

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
                        connection.Close();

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


               
            }
            catch (Exception ex)
            {
                // Display an error message
                lbl_message.Text = "Error inserting data: " + ex.Message;
            }


            finally
            {
                // Make sure to always close the database connection
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
